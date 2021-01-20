#ifndef _CORE_H
#define _CORE_H

#include "llvm-c/Core.h"
#if LLVM_VERSION_MAJOR < 3 || (LLVM_VERSION_MAJOR == 3 && LLVM_VERSION_MINOR < 8)
#include "legacy/Types.h"
#else
#include <llvm-c/Types.h>
#endif

#endif
