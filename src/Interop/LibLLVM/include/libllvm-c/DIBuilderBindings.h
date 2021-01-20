#ifndef _LIBLLVM_DIBUILDERBINDINGS_H_
#define _LIBLLVM_DIBUILDERBINDINGS_H_

#include <stdint.h>
#include "llvm-c/Core.h"
#include "legacy/Types.h"

#ifdef __cplusplus
extern "C" {
#endif

LLVMMetadataRef LibLLVMDIBuilderCreateCompileUnit(
    LLVMDIBuilderRef Builder,
    unsigned Lang,
    LLVMMetadataRef FileRef,
    const char* Producer,
    size_t ProducerLen,
    LLVMBool isOptimized,
    const char* Flags,
    size_t FlagsLen,
    unsigned RuntimeVer,
    const char* SplitName,
    size_t SplitNameLen,
    LLVMDWARFEmissionKind Kind,
    unsigned DWOId,
    LLVMBool SplitDebugInlining,
    LLVMBool DebugInfoForProfiling );

#ifdef __cplusplus
}
#endif


#endif
