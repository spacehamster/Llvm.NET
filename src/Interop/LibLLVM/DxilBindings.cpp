#include "libllvm-c/DxilBindings.h"
#include <llvm/IR/Constants.h>
#include <llvm/IR/Instructions.h>
#include <llvm/IR/LLVMContext.h>
#include <llvm/Bitcode/ReaderWriter.h>
#include <llvm/Support/raw_ostream.h>
#include <llvm/IR/AssemblyAnnotationWriter.h>
#include <llvm/Support/CBindingWrapping.h>


using namespace llvm;

DEFINE_ISA_CONVERSION_FUNCTIONS(NamedMDNode, LLVMNamedMDNodeRef)

extern "C"
{
    LLVMNamedMDNodeRef LLVMGetFirstNamedMetadata(LLVMModuleRef M) {
        Module* Mod = unwrap(M);
        Module::named_metadata_iterator I = Mod->named_metadata_begin();
        if (I == Mod->named_metadata_end())
            return nullptr;
        return wrap(&*I);
    }

    LLVMNamedMDNodeRef LLVMGetLastNamedMetadata(LLVMModuleRef M) {
        Module* Mod = unwrap(M);
        Module::named_metadata_iterator I = Mod->named_metadata_end();
        if (I == Mod->named_metadata_begin())
            return nullptr;
        return wrap(&*--I);
    }

    LLVMNamedMDNodeRef LLVMGetNextNamedMetadata(LLVMNamedMDNodeRef NMD) {
        NamedMDNode* NamedNode = unwrap<NamedMDNode>(NMD);
        Module::named_metadata_iterator I(NamedNode);
        if (++I == NamedNode->getParent()->named_metadata_end())
            return nullptr;
        return wrap(&*I);
    }

    const char* LLVMGetNamedMetadataName(LLVMNamedMDNodeRef NMD, size_t* NameLen) {
        NamedMDNode* NamedNode = unwrap<NamedMDNode>(NMD);
        *NameLen = NamedNode->getName().size();
        return NamedNode->getName().data();
    }

    const char* LLVMGetValueName2(LLVMValueRef Val, size_t* Length) {
        auto* V = unwrap(Val);
        *Length = V->getName().size();
        return V->getName().data();
    }

    void LLVMSetValueName2(LLVMValueRef Val, const char* Name, size_t NameLen) {
        unwrap(Val)->setName(StringRef(Name, NameLen));
    }

    LLVMValueRef LLVMGetCalledValue(LLVMValueRef Instr) {
        return wrap(unwrap<CallInst>(Instr)->getCalledValue());
    }


    //Target
    LLVMTargetDataRef LLVMGetModuleDataLayout(LLVMModuleRef M) {
        return wrap(&unwrap(M)->getDataLayout());
    }

    LLVMBool LLVMParseBitcodeInContext2(LLVMContextRef ContextRef,
        LLVMMemoryBufferRef MemBuf,
        LLVMModuleRef* OutModule)
    {
        auto context = unwrap(ContextRef);
        auto memBuff = unwrap(MemBuf);
        auto moduleOrErr = parseBitcodeFile(memBuff->getMemBufferRef(), *context);
        if (moduleOrErr.getError()) {
            *OutModule = wrap((Module*)nullptr);
            return 1;
        }
        *OutModule = wrap(moduleOrErr.get().release());
        return 0;
    }
}
