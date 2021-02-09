// -----------------------------------------------------------------------
// <copyright file="LLVMMetadataKind.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503841922" )]
    public enum LLVMMetadataKind : global::System.Int32
    {
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMMDStringMetadataKind"]/*' />
        LLVMMDStringMetadataKind = 0,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMConstantAsMetadataMetadataKind"]/*' />
        LLVMConstantAsMetadataMetadataKind = 1,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMLocalAsMetadataMetadataKind"]/*' />
        LLVMLocalAsMetadataMetadataKind = 2,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDistinctMDOperandPlaceholderMetadataKind"]/*' />
        LLVMDistinctMDOperandPlaceholderMetadataKind = 3,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMMDTupleMetadataKind"]/*' />
        LLVMMDTupleMetadataKind = 4,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDILocationMetadataKind"]/*' />
        LLVMDILocationMetadataKind = 5,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIExpressionMetadataKind"]/*' />
        LLVMDIExpressionMetadataKind = 6,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIGlobalVariableExpressionMetadataKind"]/*' />
        LLVMDIGlobalVariableExpressionMetadataKind = 7,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMGenericDINodeMetadataKind"]/*' />
        LLVMGenericDINodeMetadataKind = 8,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDISubrangeMetadataKind"]/*' />
        LLVMDISubrangeMetadataKind = 9,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIEnumeratorMetadataKind"]/*' />
        LLVMDIEnumeratorMetadataKind = 10,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIBasicTypeMetadataKind"]/*' />
        LLVMDIBasicTypeMetadataKind = 11,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIDerivedTypeMetadataKind"]/*' />
        LLVMDIDerivedTypeMetadataKind = 12,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDICompositeTypeMetadataKind"]/*' />
        LLVMDICompositeTypeMetadataKind = 13,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDISubroutineTypeMetadataKind"]/*' />
        LLVMDISubroutineTypeMetadataKind = 14,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIFileMetadataKind"]/*' />
        LLVMDIFileMetadataKind = 15,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDICompileUnitMetadataKind"]/*' />
        LLVMDICompileUnitMetadataKind = 16,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDISubprogramMetadataKind"]/*' />
        LLVMDISubprogramMetadataKind = 17,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDILexicalBlockMetadataKind"]/*' />
        LLVMDILexicalBlockMetadataKind = 18,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDILexicalBlockFileMetadataKind"]/*' />
        LLVMDILexicalBlockFileMetadataKind = 19,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDINamespaceMetadataKind"]/*' />
        LLVMDINamespaceMetadataKind = 20,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIModuleMetadataKind"]/*' />
        LLVMDIModuleMetadataKind = 21,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDITemplateTypeParameterMetadataKind"]/*' />
        LLVMDITemplateTypeParameterMetadataKind = 22,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDITemplateValueParameterMetadataKind"]/*' />
        LLVMDITemplateValueParameterMetadataKind = 23,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIGlobalVariableMetadataKind"]/*' />
        LLVMDIGlobalVariableMetadataKind = 24,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDILocalVariableMetadataKind"]/*' />
        LLVMDILocalVariableMetadataKind = 25,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDILabelMetadataKind"]/*' />
        LLVMDILabelMetadataKind = 26,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIObjCPropertyMetadataKind"]/*' />
        LLVMDIObjCPropertyMetadataKind = 27,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIImportedEntityMetadataKind"]/*' />
        LLVMDIImportedEntityMetadataKind = 28,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIMacroMetadataKind"]/*' />
        LLVMDIMacroMetadataKind = 29,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDIMacroFileMetadataKind"]/*' />
        LLVMDIMacroFileMetadataKind = 30,
        // **
        //  * The kind of metadata nodes.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMMetadataKind"]/Item[@name="LLVMDICommonBlockMetadataKind"]/*' />
        LLVMDICommonBlockMetadataKind = 31,
    }
}
