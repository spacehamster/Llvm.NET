//===- IRBindings.cpp - Additional bindings for ir ------------------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//
//
// This file defines additional C bindings for the ir component.
//
//===----------------------------------------------------------------------===//

#include "libllvm-c/IRBindings.h"
#include "llvm/IR/IRBuilder.h"
#include "NotImplementedException.h"

using namespace llvm;

extern "C"
{
    void LibLLVMGetVersionInfo( LibLLVMVersionInfo* pVersionInfo )
    {
        *pVersionInfo = { LLVM_VERSION_MAJOR, LLVM_VERSION_MINOR, LLVM_VERSION_PATCH };
    }

    LLVMBool LibLLVMHasUnwindDest( LLVMValueRef Invoke )
    {
        throw NotImplementedException();
    }

}
