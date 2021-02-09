#include "libllvm-c/AttributeBindings.h"
#include "libllvm-c/Core.h"
#include "llvm/IR/LLVMContext.h"
#include "llvm/IR/Value.h"
#include "llvm/Support/CBindingWrapping.h"
#include <type_traits>
#include "NotImplementedException.h"

using namespace llvm;

extern "C"
{
    char const* LibLLVMAttributeToString(LLVMAttributeRef attribute)
    {
        throw NotImplementedException();
    }

    LLVMBool LibLLVMIsTypeAttribute(LLVMAttributeRef attribute)
    {
        throw NotImplementedException();
    }

    LLVMTypeRef LibLLVMGetAttributeTypeValue(LLVMAttributeRef attribute)
    {
        throw NotImplementedException();
    }
}
