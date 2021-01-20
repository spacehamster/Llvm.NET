#include "libllvm-c/Core.h"
#include "libllvm-c/DIBuilderBindings.h"
#include <llvm/Support/CBindingWrapping.h>
#include "llvm/IR/DIBuilder.h"
#include "NotImplementedException.h"
using namespace llvm;

namespace
{
    template <typename DIT> DIT* unwrap_maybenull( LLVMMetadataRef Ref )
    {
        return (DIT* )( Ref ? unwrap<MDNode>( Ref ) : nullptr );
    }

}
DEFINE_ISA_CONVERSION_FUNCTIONS(DIBuilder, LLVMDIBuilderRef)
DEFINE_ISA_CONVERSION_FUNCTIONS(Metadata, LLVMMetadataRef)
extern "C"
{
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
        LLVMBool DebugInfoForProfiling )
    {
        throw NotImplementedException();
    }
}
