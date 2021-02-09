﻿// <copyright file="StaticState.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;

using Ubiquity.NET.Llvm.Interop.Properties;

using static Ubiquity.NET.Llvm.Interop.NativeMethods;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <summary>Provides support for various LLVM static state initialization and manipulation</summary>
    public sealed class Library
        : DisposableObject
        , ILibLlvm
    {
        /// <inheritdoc/>
        public void RegisterTarget( CodeGenTarget target, TargetRegistrations registrations = TargetRegistrations.All )
        {
            switch( target )
            {
            case CodeGenTarget.Native:
                RegisterNative( registrations );
                break;
            case CodeGenTarget.AArch64:
                RegisterAArch64( registrations );
                break;
            case CodeGenTarget.AMDGPU:
                RegisterAMDGPU( registrations );
                break;
            case CodeGenTarget.ARM:
                RegisterARM( registrations );
                break;
            case CodeGenTarget.BPF:
                RegisterBPF( registrations );
                break;
            case CodeGenTarget.Hexagon:
                RegisterHexagon( registrations );
                break;
            case CodeGenTarget.Lanai:
                RegisterLanai( registrations );
                break;
            case CodeGenTarget.MIPS:
                RegisterMips( registrations );
                break;
            case CodeGenTarget.MSP430:
                RegisterMSP430( registrations );
                break;
            case CodeGenTarget.NvidiaPTX:
                RegisterNVPTX( registrations );
                break;
            case CodeGenTarget.PowerPC:
                RegisterPowerPC( registrations );
                break;
            case CodeGenTarget.Sparc:
                RegisterSparc( registrations );
                break;
            case CodeGenTarget.SystemZ:
                RegisterSystemZ( registrations );
                break;
            case CodeGenTarget.WebAssembly:
                RegisterWebAssembly( registrations );
                break;
            case CodeGenTarget.X86:
                RegisterX86( registrations );
                break;
            case CodeGenTarget.XCore:
                RegisterXCore( registrations );
                break;
            case CodeGenTarget.RISCV:
                RegisterRISCV( registrations );
                break;
            case CodeGenTarget.All:
                RegisterAll( registrations );
                break;
            }
        }

        /// <summary>Initializes the native LLVM library support</summary>
        /// <returns>
        /// <see cref="System.IDisposable"/> implementation for the library
        /// </returns>
        /// <remarks>
        /// This can only be called once per application to initialize the
        /// LLVM library. <see cref="System.IDisposable.Dispose()"/> will release
        /// any resources allocated by the library. The current LLVM library does
        /// *NOT* support re-initialization within the same process. Thus, this
        /// is best used at the top level of the application and released at or
        /// near process exit.
        /// </remarks>
        public static ILibLlvm InitializeLLVM( )
        {
            var previousState = (InitializationState)Interlocked.CompareExchange( ref CurrentInitializationState
                                                                                , (int)InitializationState.Initializing
                                                                                , (int)InitializationState.Uninitialized
                                                                                );
            if( previousState != InitializationState.Uninitialized )
            {
                throw new InvalidOperationException( Resources.Llvm_already_initialized );
            }

            // force loading the appropriate architecture specific
            // DLL before any use of the wrapped interop APIs to
            // allow building this library as ANYCPU
            string thisModulePath = Path.GetDirectoryName( Assembly.GetExecutingAssembly( ).Location );
            if( string.IsNullOrWhiteSpace( thisModulePath ) )
            {
                throw new InvalidOperationException( Resources.Cannot_determine_assembly_location );
            }

            string packageRoot = Path.GetFullPath( Path.Combine( thisModulePath, "..", ".." ) );
            var paths = new List<string>( );

            // TODO: support other non-windows runtimes via .NET CORE
            string osArch = Environment.Is64BitProcess ? "Win-x64" : "win-x86";
            string runTimePath = Path.Combine( "runtimes", osArch, "native" );

            // .NET core apps will actually run with references directly from the NuGet install
            // but full framework apps (including unit tests will have CopyLocal applied)
            paths.Add( Path.Combine( packageRoot, runTimePath ) );
            paths.Add( Path.Combine( thisModulePath, runTimePath ) );
            paths.Add( thisModulePath );
            IntPtr hLibLLVM = LoadWin32Library( "Ubiquity.NET.LibLlvm.dll", paths );

            // Verify the version of LLVM in LibLLVM
            LibLLVMGetVersionInfo( out LibLLVMVersionInfo versionInfo );
            if( versionInfo.Major != VersionMajor
             || versionInfo.Minor != VersionMinor
             || versionInfo.Patch < VersionPatch
              )
            {
                string msgFmt = Resources.Mismatched_LibLLVM_version_Expected_0_1_2_Actual_3_4_5;
                string msg = string.Format( CultureInfo.CurrentCulture
                                          , msgFmt
                                          , VersionMajor
                                          , VersionMinor
                                          , VersionPatch
                                          , versionInfo.Major
                                          , versionInfo.Minor
                                          , versionInfo.Patch
                                          );

                throw new InvalidOperationException( msg );
            }

            // initialize the static fields
            FatalErrorHandlerDelegate = new Lazy<LLVMFatalErrorHandler>( ( ) => FatalErrorHandler, LazyThreadSafetyMode.PublicationOnly );
            LLVMInstallFatalErrorHandler( FatalErrorHandlerDelegate.Value );
            Interlocked.Exchange( ref CurrentInitializationState, ( int )InitializationState.Initialized );
            return new Library( hLibLLVM );
        }

        // TODO: Figure out how to read targets.def to get the full set of target architectures
        // and generate all of the registration (including skipping of any init calls that don't exist).

        // basic pattern to follow for any new targets in the future
        /*
        /// <summary>Registers components for the XXX target</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        public static void RegisterXXX( TargetRegistrations registrations = TargetRegistrations.All )
        {
            if( registrations.HasFlag( TargetRegistrations.Target ) )
            {
                LLVMInitializeXXXTarget( );
            }

            if( registrations.HasFlag( TargetRegistrations.TargetInfo ) )
            {
                LLVMInitializeXXXTargetInfo( );
            }

            if( registrations.HasFlag( TargetRegistrations.TargetMachine ) )
            {
                LLVMInitializeXXXTargetMC( );
            }

            if( registrations.HasFlag( TargetRegistrations.AsmPrinter ) )
            {
                LLVMInitializeXXXAsmPrinter( );
            }

            if( registrations.HasFlag( TargetRegistrations.Disassembler ) )
            {
                LLVMInitializeXXXDisassembler( );
            }

            if( registrations.HasFlag( TargetRegistrations.AsmParser ) )
            {
                LLVMInitializeXXXAsmParser( );
            }
        }
        */

        /// <summary>Registers components for all available targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterAll( TargetRegistrations registrations = TargetRegistrations.All )
        {
            if( registrations.HasFlag( TargetRegistrations.Target ) )
            {
                LLVMInitializeAllTargets( );
            }

            if( registrations.HasFlag( TargetRegistrations.TargetInfo ) )
            {
                LLVMInitializeAllTargetInfos( );
            }

            if( registrations.HasFlag( TargetRegistrations.TargetMachine ) )
            {
                LLVMInitializeAllTargetMCs( );
            }

            if( registrations.HasFlag( TargetRegistrations.AsmPrinter ) )
            {
                LLVMInitializeAllAsmPrinters( );
            }

            if( registrations.HasFlag( TargetRegistrations.Disassembler ) )
            {
                LLVMInitializeAllDisassemblers( );
            }

            if( registrations.HasFlag( TargetRegistrations.AsmParser ) )
            {
                LLVMInitializeAllAsmParsers( );
            }
        }

        /// <summary>Registers components for the target representing the system the calling process is running on</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterNative( TargetRegistrations registrations = TargetRegistrations.All )
        {
            if( registrations.HasFlag( TargetRegistrations.Target ) )
            {
                LLVMInitializeNativeTarget( );
            }

            /* Not supported on this platform
            //if( registrations.HasFlag( TargetRegistration.TargetInfo ) )
            //    LLVMInitializeNativeTargetInfo( );

            //if( registrations.HasFlag( TargetRegistration.TargetMachine ) )
            //    LLVMInitializeNativeTargetMC( );
            */

            if( registrations.HasFlag( TargetRegistrations.AsmPrinter ) )
            {
                LLVMInitializeNativeAsmPrinter( );
            }

            if( registrations.HasFlag( TargetRegistrations.Disassembler ) )
            {
                LLVMInitializeNativeDisassembler( );
            }

            if( registrations.HasFlag( TargetRegistrations.AsmParser ) )
            {
                LLVMInitializeNativeAsmParser( );
            }
        }

        /// <summary>Registers components for ARM AArch64 target(s)</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterAArch64( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for AMDGPU targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterAMDGPU( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for ARM 32bit and 16bit thumb targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterARM( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the Berkeley Packet Filter (BPF) target</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterBPF( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the Hexagon CPU</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterHexagon( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the Lanai target</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterLanai( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for MIPS targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterMips( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for MSP430 targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterMSP430( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the NVPTX targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterNVPTX( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the PowerPC targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterPowerPC( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for SPARC targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterSparc( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for SystemZ targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterSystemZ( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the WebAssembly target</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterWebAssembly( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for X86 targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterX86( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for XCore targets</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterXCore( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <summary>Registers components for the RISCV target</summary>
        /// <param name="registrations">Flags indicating which components to register/enable</param>
        internal static void RegisterRISCV( TargetRegistrations registrations = TargetRegistrations.All )
        {
            throw new StrippedFunctionException();
        }

        /// <inheritdoc/>
        protected override void Dispose( bool disposing )
        {
            InternalShutdownLLVM( ModuleHandle );
        }

        private Library( IntPtr moduleHandle )
        {
            ModuleHandle = moduleHandle;
        }

        private IntPtr ModuleHandle;

        private enum InitializationState
        {
            Uninitialized,
            Initializing,
            Initialized,
            ShuttingDown,
            ShutDown, // NOTE: This is a terminal state, it doesn't return to uninitialized
        }

        // version info for verification of matched LibLLVM
        private const int VersionMajor = 10;
        private const int VersionMinor = 0;
        private const int VersionPatch = 0;

        private static int CurrentInitializationState;

        private static void FatalErrorHandler( string reason )
        {
            // NOTE: LLVM will call exit() upon return from this function and there's no way to stop it
            Trace.TraceError( "LLVM Fatal Error: '{0}'; Application will exit.", reason );
        }

        private static void InternalShutdownLLVM( IntPtr hLibLLVM )
        {
            var previousState = (InitializationState)Interlocked.CompareExchange( ref CurrentInitializationState
                                                                                , (int)InitializationState.ShuttingDown
                                                                                , (int)InitializationState.Initialized
                                                                                );
            if( previousState != InitializationState.Initialized )
            {
                throw new InvalidOperationException( Resources.Llvm_not_initialized );
            }

            LLVMShutdown( );
            if( hLibLLVM != IntPtr.Zero )
            {
                FreeLibrary( hLibLLVM );
            }

            Interlocked.Exchange( ref CurrentInitializationState, ( int )InitializationState.ShutDown );
        }

        // lazy initialized singleton unmanaged delegate so it is never collected
        private static Lazy<LLVMFatalErrorHandler>? FatalErrorHandlerDelegate;
    }
}
