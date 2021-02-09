// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0-alpha.3.0.ci-ZZZ.503841922
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <summary>Global LLVM object handle</summary>
    [SecurityCritical]
    [GeneratedCode("LlvmBindingsGenerator","10.0.0-alpha.3.0.ci-ZZZ.503841922")]
    public class LLVMBinaryRef
        : LlvmObjectRef
    {
        /// <summary>Creates a new instance of an LLVMBinaryRef</summary>
        /// <param name="handle">Raw native pointer for the handle</param>
        /// <param name="owner">Value to indicate whether the handle is owned or not</param>
        public LLVMBinaryRef( IntPtr handle, bool owner )
            : base( owner )
        {
            SetHandle( handle );
        }

        /// <summary>Gets a Zero (<see langword="null"/>) value handle</summary>
        public static LLVMBinaryRef Zero { get; } = new LLVMBinaryRef(IntPtr.Zero, false);

        /// <inheritdoc/>
        [SecurityCritical]
        protected override bool ReleaseHandle( )
        {
            // ensure handle appears invalid from this point forward
            var prevHandle = Interlocked.Exchange( ref handle, IntPtr.Zero );
            SetHandleAsInvalid( );

            if( prevHandle != IntPtr.Zero )
            {
                LLVMDisposeBinary( prevHandle );
            }
            return true;
        }

        private LLVMBinaryRef( )
            : base( true )
        {
        }

        [DllImport( NativeMethods.LibraryPath, CallingConvention = CallingConvention.Cdecl )]
        private static extern void LLVMDisposeBinary( IntPtr p );
    }
}
