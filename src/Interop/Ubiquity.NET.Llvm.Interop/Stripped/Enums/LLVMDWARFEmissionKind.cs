// -----------------------------------------------------------------------
// <copyright file="LLVMDWARFEmissionKind.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFEmissionKind"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503841922" )]
    public enum LLVMDWARFEmissionKind : global::System.Int32
    {
        // **
        //  * The amount of debug information to emit.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFEmissionKind"]/Item[@name="LLVMDWARFEmissionNone"]/*' />
        LLVMDWARFEmissionNone = 0,
        // **
        //  * The amount of debug information to emit.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFEmissionKind"]/Item[@name="LLVMDWARFEmissionFull"]/*' />
        LLVMDWARFEmissionFull = 1,
        // **
        //  * The amount of debug information to emit.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFEmissionKind"]/Item[@name="LLVMDWARFEmissionLineTablesOnly"]/*' />
        LLVMDWARFEmissionLineTablesOnly = 2,
    }
}
