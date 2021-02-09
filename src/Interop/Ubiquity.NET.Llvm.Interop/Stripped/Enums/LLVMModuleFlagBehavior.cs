// -----------------------------------------------------------------------
// <copyright file="LLVMModuleFlagBehavior.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503382332" )]
    public enum LLVMModuleFlagBehavior : global::System.Int32
    {
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorError"]/*' />
        LLVMModuleFlagBehaviorError = 0,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorWarning"]/*' />
        LLVMModuleFlagBehaviorWarning = 1,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorRequire"]/*' />
        LLVMModuleFlagBehaviorRequire = 2,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorOverride"]/*' />
        LLVMModuleFlagBehaviorOverride = 3,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorAppend"]/*' />
        LLVMModuleFlagBehaviorAppend = 4,
        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Enumeration[@name="LLVMModuleFlagBehavior"]/Item[@name="LLVMModuleFlagBehaviorAppendUnique"]/*' />
        LLVMModuleFlagBehaviorAppendUnique = 5,
    }
}
