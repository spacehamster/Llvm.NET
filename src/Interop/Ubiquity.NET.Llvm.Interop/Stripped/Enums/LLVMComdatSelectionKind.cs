// -----------------------------------------------------------------------
// <copyright file="LLVMComdatSelectionKind.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503841922" )]
    public enum LLVMComdatSelectionKind : global::System.Int32
    {
        /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/Item[@name="LLVMAnyComdatSelectionKind"]/*' />
        LLVMAnyComdatSelectionKind = 0,
        /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/Item[@name="LLVMExactMatchComdatSelectionKind"]/*' />
        LLVMExactMatchComdatSelectionKind = 1,
        /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/Item[@name="LLVMLargestComdatSelectionKind"]/*' />
        LLVMLargestComdatSelectionKind = 2,
        /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/Item[@name="LLVMNoDuplicatesComdatSelectionKind"]/*' />
        LLVMNoDuplicatesComdatSelectionKind = 3,
        /// <include file="../../ApiDocs/llvm-c/Comdat.xml" path='LibLlvmAPI/Enumeration[@name="LLVMComdatSelectionKind"]/Item[@name="LLVMSameSizeComdatSelectionKind"]/*' />
        LLVMSameSizeComdatSelectionKind = 4,
    }
}
