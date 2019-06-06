﻿// -----------------------------------------------------------------------
// <copyright file="OrcJit.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Llvm.NET.Interop;
using Llvm.NET.Properties;

using static Llvm.NET.Interop.NativeMethods;

namespace Llvm.NET.JIT
{
    /// <summary>LLVM On Request Compilation (ORC) Just-In-Time (JIT) Engine</summary>
    /// <remarks>
    /// The LLVM OrcJIT supports lazy compilation and better resource management for
    /// clients. For more details on the implementation see the LLVM Documentation.
    /// </remarks>
    public class OrcJit
        : DisposableObject
        , ILazyCompileExecutionEngine
    {
        /// <summary>Initializes a new instance of the <see cref="OrcJit"/> class for a given target machine.</summary>
        /// <param name="machine">Target machine for the JIT</param>
        public OrcJit( TargetMachine machine )
        {
            JitStackHandle = LLVMOrcCreateInstance( machine.TargetMachineHandle );
            TargetMachine = machine;
        }

        /// <inheritdoc/>
        public TargetMachine TargetMachine { get; }

        /// <summary>Add a module to the engine</summary>
        /// <param name="bitcodeModule">The module to add to the engine</param>
        /// <returns>Handle for the module in the engine</returns>
        /// <remarks>
        /// Once the module is provided to the engine it is fully owned by the engine and should
        /// be considered res-only to the calling app.
        /// </remarks>
        public ulong AddModule( BitcodeModule bitcodeModule )
        {
            return AddModule( bitcodeModule, DefaultSymbolResolver );
        }

        /// <summary>Add a module to the engine</summary>
        /// <param name="bitcodeModule">The module to add to the engine</param>
        /// <param name="resolver">Symbol resolver delegate</param>
        /// <returns>Handle for the module in the engine</returns>
        /// <remarks>
        /// <note type="warning">
        /// Ownership of the <paramref name="bitcodeModule"/> is transfered to the JIT engine and therefore,
        /// after successful completion of this call the module reports as disposed.
        /// </note>
        /// <note type="important">
        /// The <paramref name="resolver"/> must not throw an exception as the native LLVM JIT engine
        /// won't understand it and would leave the engine and LLVM in an inconsistent state. If the
        /// symbol isn't found LLVM generates an error message in debug builds and in all builds, terminates
        /// the application.
        /// </note>
        /// </remarks>
        public ulong AddModule( BitcodeModule bitcodeModule, LLVMOrcSymbolResolverFn resolver )
        {
#if LLVM_COFF_EXPORT_BUG_FIXED
/* see: https://reviews.llvm.org/rL258665 */
            var wrappedResolver = new WrappedNativeCallback<LLVMOrcSymbolResolverFn>( resolver );
            var err = LLVMOrcAddEagerlyCompiledIR( JitStackHandle, out ulong retHandle, bitcodeModule.ModuleHandle, wrappedResolver, IntPtr.Zero );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString( ) );
            }

            bitcodeModule.Detach( );

            // keep resolver delegate alive as native code needs to call it after this function exits
            SymbolResolvers.Add( retHandle, wrappedResolver );
            return retHandle;
#else
            return LazyAddModule( bitcodeModule, resolver );
#endif
        }

        /// <inheritdoc/>
        public void RemoveModule( ulong handle )
        {
            var err = LLVMOrcRemoveModule( JitStackHandle, handle );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString() );
            }

            SymbolResolvers.Remove( handle );
        }

        /// <inheritdoc/>
        [SuppressMessage( "Design", "CA1031:Do not catch general exception types", Justification = "Native callback function *MUST NOT* surface managed exceptions" )]
        public ulong DefaultSymbolResolver( string name, IntPtr ctx )
        {
            try
            {
                var err = LLVMOrcGetSymbolAddress( JitStackHandle, out ulong retAddr, name );
                if( !err.IsInvalid )
                {
                    throw new InvalidOperationException( string.Format( CultureInfo.CurrentCulture, Resources.Unresolved_Symbol_0_1, name, LLVMOrcGetErrorMsg( JitStackHandle ) ) );
                }

                return retAddr != 0
                    ? retAddr
                    : GlobalInteropFunctions.TryGetValue( name, out WrappedNativeCallback callBack ) ? ( ulong )callBack.ToIntPtr().ToInt64( ) : 0;
            }
            catch
            {
                // Allowing exceptions outside this call is not helpful as the LLVM
                // native JIT engine is what calls this function and it doesn't know
                // how to deal with a managed exception. Any exceptions are at least
                // logged in a debugger before being swallowed here.
                return 0;
            }
        }

        /// <inheritdoc/>
        public T GetFunctionDelegate<T>( string name )
        {
            var err = LLVMOrcGetSymbolAddress( JitStackHandle, out UInt64 retAddr, name );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString( ) );
            }

            if( retAddr == 0 )
            {
                throw new KeyNotFoundException( string.Format( CultureInfo.CurrentCulture, Resources.Function_0_not_found, name ) );
            }

            return Marshal.GetDelegateForFunctionPointer<T>( ( IntPtr )retAddr );
        }

        /// <summary>Adds or replaces an interop callback for a global symbol</summary>
        /// <typeparam name="T">Delegate type for the callback</typeparam>
        /// <param name="symbolName">Symbol name of the global</param>
        /// <param name="delegate">Delegate for the callback</param>
        /// <remarks>
        /// <note type="warning">
        /// The delegate is made available to native code as a callback, and therefore it
        /// must have a lifetime that is at least as long as the callback is registered or
        /// the lifetime of the JIT engine itself. The direct delegate and any instance
        /// it may be a member of are handled automatically in the internal implementation
        /// of this function. However, any data the delegate may rely on is not. (e.g. if
        /// the object the delegate is a method on a class implementing IDisposable and the
        /// Dispose method was called on that instance, then the callback could end up operating
        /// on a disposed object)
        /// </note>
        /// <note type="warning">
        /// The callback **MUST NOT** throw any exceptions out of the callback, as the
        /// JIT engine doesn't know how to handle them and neither does the JIT'd code.
        /// </note>
        /// </remarks>
        public void AddInteropCallback<T>( string symbolName, T @delegate )
            where T : Delegate
        {
            LLVMOrcGetMangledSymbol( JitStackHandle, out string mangledName, symbolName );
            if( GlobalInteropFunctions.TryGetValue( mangledName, out WrappedNativeCallback existingCallback ) )
            {
                GlobalInteropFunctions.Remove( mangledName );
                existingCallback.Dispose( );
            }

            GlobalInteropFunctions.Add( mangledName, new WrappedNativeCallback<T>( @delegate ) );
        }

        /// <inheritdoc/>
        public ulong LazyAddModule( BitcodeModule bitcodeModule, LLVMOrcSymbolResolverFn resolver )
        {
            var wrappedResolver = new WrappedNativeCallback<LLVMOrcSymbolResolverFn>( resolver );

            var err = LLVMOrcAddLazilyCompiledIR( JitStackHandle, out ulong retHandle, bitcodeModule.ModuleHandle, wrappedResolver, IntPtr.Zero );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString( ) );
            }

            bitcodeModule.Detach( );

            // keep resolver delegate alive as native code needs to call it after this function exits
            SymbolResolvers.Add( retHandle, wrappedResolver );
            return retHandle;
        }

        /// <inheritdoc/>
        public void AddLazyFunctionGenerator( string name, LazyFunctionCompiler generator, IntPtr context )
        {
            LLVMOrcGetMangledSymbol( JitStackHandle, out string mangledName, name );

            // wrap the provided generator function for a safe native callback
            UInt64 CompileAction( LLVMOrcJITStackRef jitStackHandle, IntPtr ctx )
            {
                try
                {
                    (string implName, BitcodeModule module) = generator( );
                    if( module == null )
                    {
                        return 0;
                    }

                    AddModule( module );
                    var e = LLVMOrcGetSymbolAddress( JitStackHandle, out UInt64 implAddr, implName );
                    if( !e.IsInvalid )
                    {
                        throw new LlvmException( e.ToString() );
                    }

                    e = LLVMOrcSetIndirectStubPointer( JitStackHandle, mangledName, implAddr );
                    if( !e.IsInvalid )
                    {
                        throw new LlvmException( e.ToString() );
                    }

                    LazyFunctionGenerators.Remove( mangledName );
                    return implAddr;
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch
                {
                    // native callback - MUST NOT leak exceptions out of this call.
                    return 0;
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }

            var callbackAction = new WrappedNativeCallback<LLVMOrcLazyCompileCallbackFn>( CompileAction );
            LazyFunctionGenerators.Add( mangledName, callbackAction );

            var err = LLVMOrcCreateLazyCompileCallback( JitStackHandle, out UInt64 stubAddr, callbackAction, context );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString() );
            }

            err = LLVMOrcCreateIndirectStub( JitStackHandle, mangledName, stubAddr );
            if( !err.IsInvalid )
            {
                throw new LlvmException( err.ToString( ) );
            }
        }

        /// <inheritdoc/>
        protected override void Dispose( bool disposing )
        {
            DisposeCallbacks( GlobalInteropFunctions );
            DisposeCallbacks( SymbolResolvers );
            DisposeCallbacks( LazyFunctionGenerators );
            JitStackHandle.Dispose( );
        }

        private static void DisposeCallbacks<T,T2>( IDictionary<T, T2> map )
            where T2 : WrappedNativeCallback
        {
            foreach( var callBack in map.Values )
            {
                callBack.Dispose( );
            }

            map.Clear( );
        }

        private readonly Dictionary<string, WrappedNativeCallback> GlobalInteropFunctions
            = new Dictionary<string, WrappedNativeCallback>();

        private readonly Dictionary<UInt64, WrappedNativeCallback<LLVMOrcSymbolResolverFn>> SymbolResolvers
            = new Dictionary<UInt64, WrappedNativeCallback<LLVMOrcSymbolResolverFn>>();

        private readonly Dictionary<string, WrappedNativeCallback<LLVMOrcLazyCompileCallbackFn>> LazyFunctionGenerators
            = new Dictionary<string, WrappedNativeCallback<LLVMOrcLazyCompileCallbackFn>>();

        private readonly LLVMOrcJITStackRef JitStackHandle;
    }
}