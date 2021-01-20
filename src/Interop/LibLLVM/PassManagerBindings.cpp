//===- InstrumentationBindings.cpp - instrumentation bindings -------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//
//
// This file defines C bindings for the instrumentation component.
//
//===----------------------------------------------------------------------===//

#include "libllvm-c/PassManagerBindings.h"

#include <llvm-c/Core.h>
#include <llvm/IR/LegacyPassManager.h>
#include <llvm/IR/Module.h>
#include <llvm/Transforms/Instrumentation.h>
#include <llvm/PassRegistry.h>
#include "NotImplementedException.h"

using namespace llvm;

extern "C"
{
    LLVMPassRegistryRef LibLLVMCreatePassRegistry( )
    {
        return wrap( new PassRegistry( ) );
    }

    void LibLLVMPassRegistryDispose( LLVMPassRegistryRef passReg )
    {
        delete unwrap( passReg );
    }

    void LibLLVMAddAddressSanitizerFunctionPass( LLVMPassManagerRef PM )
    {
        throw NotImplementedException();
    }

    void LibLLVMAddAddressSanitizerModulePass( LLVMPassManagerRef PM )
    {
        throw NotImplementedException();
    }

    void LibLLVMAddThreadSanitizerPass( LLVMPassManagerRef PM )
    {
        throw NotImplementedException();
    }

    void LibLLVMAddMemorySanitizerPass( LLVMPassManagerRef PM )
    {
        throw NotImplementedException();
    }

    void LibLLVMAddDataFlowSanitizerPass( LLVMPassManagerRef PM, int ABIListFilesNum, const char **ABIListFiles )
    {
        throw NotImplementedException();
    }
}
