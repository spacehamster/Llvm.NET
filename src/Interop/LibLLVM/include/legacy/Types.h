#ifndef _TYPES_H_
#define _TYPES_H_

/**
 * Used to represent an attributes.
 *
 * @see llvm::Attribute
 */
typedef struct LLVMOpaqueAttributeRef *LLVMAttributeRef;

/**
 * Represents an LLVM Metadata.
 *
 * This models llvm::Metadata.
 */
typedef struct LLVMOpaqueMetadata *LLVMMetadataRef;

/**
 * Represents an LLVM debug info builder.
 *
 * This models llvm::DIBuilder.
 */
typedef struct LLVMOpaqueDIBuilder *LLVMDIBuilderRef;

/**
 * Represents an LLVM Named Metadata Node.
 *
 * This models llvm::NamedMDNode.
 */
typedef struct LLVMOpaqueNamedMDNode *LLVMNamedMDNodeRef;

/**
 * @see llvm::Comdat
 */
typedef struct LLVMComdat *LLVMComdatRef;

/**
 * @see llvm::Module::ModuleFlagEntry
 */
typedef struct LLVMOpaqueModuleFlagEntry LLVMModuleFlagEntry;



typedef enum {
    LLVMAnyComdatSelectionKind,        ///< The linker may choose any COMDAT.
    LLVMExactMatchComdatSelectionKind, ///< The data referenced by the COMDAT must
    ///< be the same.
    LLVMLargestComdatSelectionKind,    ///< The linker will choose the largest
    ///< COMDAT.
    LLVMNoDuplicatesComdatSelectionKind, ///< No other Module may specify this
    ///< COMDAT.
    LLVMSameSizeComdatSelectionKind ///< The data referenced by the COMDAT must be
    ///< the same size.
} LLVMComdatSelectionKind;

typedef enum {
    LLVMDIFlagZero = 0,
    LLVMDIFlagPrivate = 1,
    LLVMDIFlagProtected = 2,
    LLVMDIFlagPublic = 3,
    LLVMDIFlagFwdDecl = 1 << 2,
    LLVMDIFlagAppleBlock = 1 << 3,
    LLVMDIFlagReservedBit4 = 1 << 4,
    LLVMDIFlagVirtual = 1 << 5,
    LLVMDIFlagArtificial = 1 << 6,
    LLVMDIFlagExplicit = 1 << 7,
    LLVMDIFlagPrototyped = 1 << 8,
    LLVMDIFlagObjcClassComplete = 1 << 9,
    LLVMDIFlagObjectPointer = 1 << 10,
    LLVMDIFlagVector = 1 << 11,
    LLVMDIFlagStaticMember = 1 << 12,
    LLVMDIFlagLValueReference = 1 << 13,
    LLVMDIFlagRValueReference = 1 << 14,
    LLVMDIFlagReserved = 1 << 15,
    LLVMDIFlagSingleInheritance = 1 << 16,
    LLVMDIFlagMultipleInheritance = 2 << 16,
    LLVMDIFlagVirtualInheritance = 3 << 16,
    LLVMDIFlagIntroducedVirtual = 1 << 18,
    LLVMDIFlagBitField = 1 << 19,
    LLVMDIFlagNoReturn = 1 << 20,
    LLVMDIFlagTypePassByValue = 1 << 22,
    LLVMDIFlagTypePassByReference = 1 << 23,
    LLVMDIFlagEnumClass = 1 << 24,
    LLVMDIFlagFixedEnum = LLVMDIFlagEnumClass, // Deprecated.
    LLVMDIFlagThunk = 1 << 25,
    LLVMDIFlagNonTrivial = 1 << 26,
    LLVMDIFlagBigEndian = 1 << 27,
    LLVMDIFlagLittleEndian = 1 << 28,
    LLVMDIFlagIndirectVirtualBase = (1 << 2) | (1 << 5),
    LLVMDIFlagAccessibility = LLVMDIFlagPrivate | LLVMDIFlagProtected |
    LLVMDIFlagPublic,
    LLVMDIFlagPtrToMemberRep = LLVMDIFlagSingleInheritance |
    LLVMDIFlagMultipleInheritance |
    LLVMDIFlagVirtualInheritance
} LLVMDIFlags;


typedef unsigned LLVMMetadataKind;

/**
 * The amount of debug information to emit.
 */
typedef enum {
    LLVMDWARFEmissionNone = 0,
    LLVMDWARFEmissionFull,
    LLVMDWARFEmissionLineTablesOnly
} LLVMDWARFEmissionKind;

#endif
