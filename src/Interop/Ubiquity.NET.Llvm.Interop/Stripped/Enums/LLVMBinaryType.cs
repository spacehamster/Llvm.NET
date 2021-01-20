// -----------------------------------------------------------------------
// <copyright file="LLVMBinaryType.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503382332" )]
    public enum LLVMBinaryType : global::System.Int32
    {
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeArchive"]/*' />
        LLVMBinaryTypeArchive = 0,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeMachOUniversalBinary"]/*' />
        LLVMBinaryTypeMachOUniversalBinary = 1,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeCOFFImportFile"]/*' />
        LLVMBinaryTypeCOFFImportFile = 2,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeIR"]/*' />
        LLVMBinaryTypeIR = 3,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeWinRes"]/*' />
        LLVMBinaryTypeWinRes = 4,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeCOFF"]/*' />
        LLVMBinaryTypeCOFF = 5,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeELF32L"]/*' />
        LLVMBinaryTypeELF32L = 6,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeELF32B"]/*' />
        LLVMBinaryTypeELF32B = 7,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeELF64L"]/*' />
        LLVMBinaryTypeELF64L = 8,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeELF64B"]/*' />
        LLVMBinaryTypeELF64B = 9,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeMachO32L"]/*' />
        LLVMBinaryTypeMachO32L = 10,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeMachO32B"]/*' />
        LLVMBinaryTypeMachO32B = 11,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeMachO64L"]/*' />
        LLVMBinaryTypeMachO64L = 12,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeMachO64B"]/*' />
        LLVMBinaryTypeMachO64B = 13,
        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Enumeration[@name="LLVMBinaryType"]/Item[@name="LLVMBinaryTypeWasm"]/*' />
        LLVMBinaryTypeWasm = 14,
    }
}
