#include "libllvm-c/ContextBindings.h"
#include <llvm/IR/LLVMContext.h>
#include "NotImplementedException.h"

using namespace llvm;

extern "C"
{
    LLVMBool LibLLVMContextGetIsODRUniquingDebugTypes( LLVMContextRef context )
    {
        throw NotImplementedException();
    }

    void LibLLVMContextSetIsODRUniquingDebugTypes( LLVMContextRef context, LLVMBool state )
    {
        throw NotImplementedException();
    }
}
