#ifndef _DXIL_DISASSEMBLER_BINDINGS_H_
#define _DXIL_DISASSEMBLER_BINDINGS_H_
#include <llvm/IR/Module.h>


#ifdef __cplusplus
extern "C" {
#endif
    char const* LibLLVMPrintModuleToStringWithDxcAssemblyAnnotationWriter(LLVMModuleRef);
#ifdef __cplusplus
}
#endif

#endif
