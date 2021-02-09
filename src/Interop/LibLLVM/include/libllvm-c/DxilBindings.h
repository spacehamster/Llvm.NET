#ifndef _DXIL_BINDINGS_
#define _DXIL_BINDINGS_
#include <llvm-c/Core.h>
#include <llvm/IR/Metadata.h>
#include <llvm/IR/Module.h>
#include <llvm/Support/CBindingWrapping.h>
#include "legacy/Types.h"

#ifdef __cplusplus
extern "C" {
#endif
    //Core
    LLVMNamedMDNodeRef LLVMGetFirstNamedMetadata(LLVMModuleRef M);
    LLVMNamedMDNodeRef LLVMGetLastNamedMetadata(LLVMModuleRef M);
    LLVMNamedMDNodeRef LLVMGetNextNamedMetadata(LLVMNamedMDNodeRef NMD);
    const char* LLVMGetNamedMetadataName(LLVMNamedMDNodeRef NMD, size_t* NameLen);
    const char* LLVMGetValueName2(LLVMValueRef Val, size_t* Length);
    void LLVMSetValueName2(LLVMValueRef Val, const char* Name, size_t NameLen);
    LLVMValueRef LLVMGetCalledValue(LLVMValueRef Instr);

    //Target
    LLVMTargetDataRef LLVMGetModuleDataLayout(LLVMModuleRef M);

    //IRReader
    LLVMBool LLVMParseBitcodeInContext2(LLVMContextRef ContextRef, LLVMMemoryBufferRef MemBuf, LLVMModuleRef* OutModule);
#ifdef __cplusplus
}
#endif

#endif
