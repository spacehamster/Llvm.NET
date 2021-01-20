// -----------------------------------------------------------------------
// <copyright file="LLVMUnnamedAddr.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMUnnamedAddr"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503382332" )]
    public enum LLVMUnnamedAddr : global::System.Int32
    {
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMUnnamedAddr"]/Item[@name="LLVMNoUnnamedAddr"]/*' />
        LLVMNoUnnamedAddr = 0,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMUnnamedAddr"]/Item[@name="LLVMLocalUnnamedAddr"]/*' />
        LLVMLocalUnnamedAddr = 1,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMUnnamedAddr"]/Item[@name="LLVMGlobalUnnamedAddr"]/*' />
        LLVMGlobalUnnamedAddr = 2,
    }
}
