#include <type_traits>
#include <llvm/IR/Module.h>
#include <llvm/Bitcode/ReaderWriter.h>
#include <llvm/Bitcode/BitstreamReader.h>
#include <llvm/IR/LLVMContext.h>
#include "libllvm-c/ModuleBindings.h"
#include "NotImplementedException.h"

using namespace llvm;

DEFINE_SIMPLE_CONVERSION_FUNCTIONS( NamedMDNode, LLVMNamedMDNodeRef )
DEFINE_SIMPLE_CONVERSION_FUNCTIONS(Comdat, LLVMComdatRef)
DEFINE_ISA_CONVERSION_FUNCTIONS(Value, LLVMValueRef)

inline LLVMModuleRef* wrap(const Module** Tys) {
    return reinterpret_cast<LLVMModuleRef*>(const_cast<Module**>(Tys));
}

extern "C"
{
    LLVMValueRef LibLLVMGetOrInsertFunction( LLVMModuleRef module, const char* name, LLVMTypeRef functionType )
    {
        throw NotImplementedException();
    }

    char const* LibLLVMGetModuleSourceFileName( LLVMModuleRef module )
    {
        throw NotImplementedException();
    }

    void LibLLVMSetModuleSourceFileName( LLVMModuleRef module, char const* name )
    {
        throw NotImplementedException();
    }

    char const* LibLLVMGetModuleName( LLVMModuleRef module )
    {
        auto pModule = unwrap( module );
        return pModule->getModuleIdentifier( ).c_str( );
    }

    LLVMValueRef LibLLVMGetGlobalAlias( LLVMModuleRef module, char const* name )
    {
        throw NotImplementedException();
    }

    LLVMComdatRef LibLLVMModuleInsertOrUpdateComdat( LLVMModuleRef module, char const* name, LLVMComdatSelectionKind kind )
    {
        auto pModule = unwrap( module );
        auto pComdat = pModule->getOrInsertComdat( name );
        pComdat->setSelectionKind( ( Comdat::SelectionKind ) kind );
        return wrap( pComdat );
    }

    void LibLLVMModuleEnumerateComdats( LLVMModuleRef module, LibLLVMComdatIteratorCallback callback )
    {
        auto pModule = unwrap( module );
        for( auto&& entry : pModule->getComdatSymbolTable( ) )
        {
            if( !callback( wrap( &entry.second ) ) )
                break;
        }
    }

    void LibLLVMModuleComdatRemove( LLVMModuleRef module, LLVMComdatRef comdatRef )
    {
        auto pModule = unwrap( module );
        auto pComdat = unwrap( comdatRef );
        pModule->getComdatSymbolTable( ).erase( pComdat->getName( ) );
    }

    void LibLLVMModuleComdatClear( LLVMModuleRef module )
    {
        auto pModule = unwrap( module );
        pModule->getComdatSymbolTable( ).clear( );
    }

    char const* LibLLVMComdatGetName( LLVMComdatRef comdatRef )
    {
        Comdat const& comdat = *unwrap( comdatRef );
        return LLVMCreateMessage( comdat.getName( ).str( ).c_str( ) );
    }

    LLVMValueRef LibLLVMModuleGetFirstGlobalAlias( LLVMModuleRef M )
    {
        throw NotImplementedException();
    }

    LLVMValueRef LibLLVMModuleGetNextGlobalAlias( LLVMValueRef valueRef )
    {
        throw NotImplementedException();
    }
}
