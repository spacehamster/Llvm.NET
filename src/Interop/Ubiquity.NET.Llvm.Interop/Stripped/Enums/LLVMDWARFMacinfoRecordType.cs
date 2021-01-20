// -----------------------------------------------------------------------
// <copyright file="LLVMDWARFMacinfoRecordType.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503841922" )]
    public enum LLVMDWARFMacinfoRecordType : global::System.Int32
    {
        // **
        //  * Describes the kind of macro declaration used for LLVMDIBuilderCreateMacro.
        //  * @see llvm::dwarf::MacinfoRecordType
        //  * @note Values are from DW_MACINFO_* constants in the DWARF specification.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/Item[@name="LLVMDWARFMacinfoRecordTypeDefine"]/*' />
        LLVMDWARFMacinfoRecordTypeDefine = 1,
        // **
        //  * Describes the kind of macro declaration used for LLVMDIBuilderCreateMacro.
        //  * @see llvm::dwarf::MacinfoRecordType
        //  * @note Values are from DW_MACINFO_* constants in the DWARF specification.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/Item[@name="LLVMDWARFMacinfoRecordTypeMacro"]/*' />
        LLVMDWARFMacinfoRecordTypeMacro = 2,
        // **
        //  * Describes the kind of macro declaration used for LLVMDIBuilderCreateMacro.
        //  * @see llvm::dwarf::MacinfoRecordType
        //  * @note Values are from DW_MACINFO_* constants in the DWARF specification.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/Item[@name="LLVMDWARFMacinfoRecordTypeStartFile"]/*' />
        LLVMDWARFMacinfoRecordTypeStartFile = 3,
        // **
        //  * Describes the kind of macro declaration used for LLVMDIBuilderCreateMacro.
        //  * @see llvm::dwarf::MacinfoRecordType
        //  * @note Values are from DW_MACINFO_* constants in the DWARF specification.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/Item[@name="LLVMDWARFMacinfoRecordTypeEndFile"]/*' />
        LLVMDWARFMacinfoRecordTypeEndFile = 4,
        // **
        //  * Describes the kind of macro declaration used for LLVMDIBuilderCreateMacro.
        //  * @see llvm::dwarf::MacinfoRecordType
        //  * @note Values are from DW_MACINFO_* constants in the DWARF specification.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDWARFMacinfoRecordType"]/Item[@name="LLVMDWARFMacinfoRecordTypeVendorExt"]/*' />
        LLVMDWARFMacinfoRecordTypeVendorExt = 255,
    }
}
