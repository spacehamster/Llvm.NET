// -----------------------------------------------------------------------
// <copyright file="LLVMDIFlags.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.CodeDom.Compiler;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/*[not(self::Item)]' />
    [GeneratedCode( "LlvmBindingsGenerator", "10.0.0-alpha.3.0.ci-ZZZ.503841922" )]
    public enum LLVMDIFlags : global::System.Int32
    {
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagZero"]/*' />
        LLVMDIFlagZero = 0,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagPrivate"]/*' />
        LLVMDIFlagPrivate = 1,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagProtected"]/*' />
        LLVMDIFlagProtected = 2,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagPublic"]/*' />
        LLVMDIFlagPublic = 3,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagFwdDecl"]/*' />
        LLVMDIFlagFwdDecl = 4,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagAppleBlock"]/*' />
        LLVMDIFlagAppleBlock = 8,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagReservedBit4"]/*' />
        LLVMDIFlagReservedBit4 = 16,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagVirtual"]/*' />
        LLVMDIFlagVirtual = 32,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagArtificial"]/*' />
        LLVMDIFlagArtificial = 64,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagExplicit"]/*' />
        LLVMDIFlagExplicit = 128,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagPrototyped"]/*' />
        LLVMDIFlagPrototyped = 256,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagObjcClassComplete"]/*' />
        LLVMDIFlagObjcClassComplete = 512,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagObjectPointer"]/*' />
        LLVMDIFlagObjectPointer = 1024,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagVector"]/*' />
        LLVMDIFlagVector = 2048,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagStaticMember"]/*' />
        LLVMDIFlagStaticMember = 4096,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagLValueReference"]/*' />
        LLVMDIFlagLValueReference = 8192,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagRValueReference"]/*' />
        LLVMDIFlagRValueReference = 16384,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagReserved"]/*' />
        LLVMDIFlagReserved = 32768,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagSingleInheritance"]/*' />
        LLVMDIFlagSingleInheritance = 65536,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagMultipleInheritance"]/*' />
        LLVMDIFlagMultipleInheritance = 131072,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagVirtualInheritance"]/*' />
        LLVMDIFlagVirtualInheritance = 196608,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagIntroducedVirtual"]/*' />
        LLVMDIFlagIntroducedVirtual = 262144,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagBitField"]/*' />
        LLVMDIFlagBitField = 524288,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagNoReturn"]/*' />
        LLVMDIFlagNoReturn = 1048576,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagTypePassByValue"]/*' />
        LLVMDIFlagTypePassByValue = 4194304,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagTypePassByReference"]/*' />
        LLVMDIFlagTypePassByReference = 8388608,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagEnumClass"]/*' />
        LLVMDIFlagEnumClass = 16777216,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagFixedEnum"]/*' />
        LLVMDIFlagFixedEnum = 16777216,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagThunk"]/*' />
        LLVMDIFlagThunk = 33554432,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagNonTrivial"]/*' />
        LLVMDIFlagNonTrivial = 67108864,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagBigEndian"]/*' />
        LLVMDIFlagBigEndian = 134217728,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagLittleEndian"]/*' />
        LLVMDIFlagLittleEndian = 268435456,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagIndirectVirtualBase"]/*' />
        LLVMDIFlagIndirectVirtualBase = 36,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagAccessibility"]/*' />
        LLVMDIFlagAccessibility = 3,
        // **
        //  * Debug info flags.
        //  *
        /// <include file="../../ApiDocs/llvm-c/DebugInfo.xml" path='LibLlvmAPI/Enumeration[@name="LLVMDIFlags"]/Item[@name="LLVMDIFlagPtrToMemberRep"]/*' />
        LLVMDIFlagPtrToMemberRep = 196608,
    }
}
