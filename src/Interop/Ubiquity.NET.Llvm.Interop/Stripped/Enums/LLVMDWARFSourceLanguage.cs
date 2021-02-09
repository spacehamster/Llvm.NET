// -----------------------------------------------------------------------
// <copyright file="LLVMAttributeIndex.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMAttributeIndex"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503382332" )]
    public enum LLVMAttributeIndex : global::System.Int32
    {
        // **
        //  * Attribute index are either LLVMAttributeReturnIndex,
        //  * LLVMAttributeFunctionIndex or a parameter number from 1 to N.
        //  *
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMAttributeIndex"]/Item[@name="LLVMAttributeReturnIndex"]/*' />
        LLVMAttributeReturnIndex = 0,
        // **
        //  * Attribute index are either LLVMAttributeReturnIndex,
        //  * LLVMAttributeFunctionIndex or a parameter number from 1 to N.
        //  *
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMAttributeIndex"]/Item[@name="LLVMAttributeFunctionIndex"]/*' />
        LLVMAttributeFunctionIndex = -1,
    }
}
