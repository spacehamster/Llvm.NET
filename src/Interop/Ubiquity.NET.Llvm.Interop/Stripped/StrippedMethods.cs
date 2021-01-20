// <copyright file="StrippedMethods.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>

using System.Runtime.InteropServices;
using System.Security;

#pragma warning disable SA1601, SA1600 // Partial elements should be documented
#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1401 // P/Invokes should not be visible
#pragma warning disable SA1508 // Closing braces should not be preceded by blank line
#pragma warning disable SA1615 // Element return value should be documented
#pragma warning disable SA1604 // Element documentation should have summary
#pragma warning disable SA1611 // Element parameters should be documented
#pragma warning disable SA1507 // Code should not contain multiple blank lines in a row
namespace Ubiquity.NET.Llvm.Interop
{
    public static partial class NativeMethods
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMModuleFlagEntry LLVMCopyModuleFlagsMetadata(LLVMModuleRef M, out size_t Len);

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMModuleFlagBehavior LLVMModuleFlagEntriesGetFlagBehavior(LLVMModuleFlagEntry Entries, uint Index);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMModuleFlagEntriesGetKey"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMModuleFlagEntriesGetKey(LLVMModuleFlagEntry Entries, uint Index, out size_t Len);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMModuleFlagEntriesGetMetadata"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMModuleFlagEntriesGetMetadata(LLVMModuleFlagEntry Entries, uint Index);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetFirstGlobalIFunc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetFirstGlobalIFunc(LLVMModuleRef M);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetNextGlobalIFunc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetNextGlobalIFunc(LLVMValueRef IFunc);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetModuleInlineAsm"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetModuleInlineAsm(LLVMModuleRef M, out size_t Len);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetModuleInlineAsm2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetModuleInlineAsm2(LLVMModuleRef M, [MarshalAs( UnmanagedType.LPStr )] string Asm, size_t Len);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAppendModuleInlineAsm"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAppendModuleInlineAsm(LLVMModuleRef M, [MarshalAs( UnmanagedType.LPStr )] string Asm, size_t Len);


        /// <include file="../../ApiDocs/llvm-c/Linker.xml" path='LibLlvmAPI/Function[@name="LLVMLinkModules2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMStatus LLVMLinkModules2(LLVMModuleRef Dest, LLVMModuleRef Src);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAddGlobalIFunc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMAddGlobalIFunc(LLVMModuleRef M, [MarshalAs( UnmanagedType.LPStr )] string Name, size_t NameLen, LLVMTypeRef Ty, uint AddrSpace, LLVMValueRef Resolver);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetNamedGlobalIFunc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetNamedGlobalIFunc(LLVMModuleRef M, [MarshalAs( UnmanagedType.LPStr )] string Name, size_t NameLen);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAddModuleFlag"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddModuleFlag(LLVMModuleRef M, LLVMModuleFlagBehavior Behavior, [MarshalAs( UnmanagedType.LPStr )] string Key, size_t KeyLen, LLVMMetadataRef Val);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMIntrinsicIsOverloaded"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIntrinsicIsOverloaded(uint ID);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetIntrinsicDeclaration"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetIntrinsicDeclaration(LLVMModuleRef Mod, uint ID, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMTypeRef[] ParamTypes, size_t ParamCount);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetAtomicRMWBinOp"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAtomicRMWBinOp LLVMGetAtomicRMWBinOp(LLVMValueRef AtomicRMWInst);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetAtomicRMWBinOp"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetAtomicRMWBinOp(LLVMValueRef AtomicRMWInst, LLVMAtomicRMWBinOp BinOp);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMInstructionGetAllMetadataOtherThanDebugLoc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueMetadataEntry LLVMInstructionGetAllMetadataOtherThanDebugLoc(LLVMValueRef Instr, out size_t NumEntries);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMValueMetadataEntriesGetMetadata"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMValueMetadataEntriesGetMetadata(LLVMValueMetadataEntry Entries, uint Index);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMObjectFileCopySymbolIterator"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMSymbolIteratorRef LLVMObjectFileCopySymbolIterator(LLVMBinaryRef BR);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMMoveToNextSymbol"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMMoveToNextSymbol(LLVMSymbolIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMCreateBinary"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMBinaryRef LLVMCreateBinary(LLVMMemoryBufferRef MemBuf, LLVMContextRef Context, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )] out string ErrorMessage);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetUnnamedAddress"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMUnnamedAddr LLVMGetUnnamedAddress(LLVMValueRef Global);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetUnnamedAddress"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetUnnamedAddress(LLVMValueRef Global, LLVMUnnamedAddr UnnamedAddr);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMBinaryGetType"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMBinaryType LLVMBinaryGetType(LLVMBinaryRef BR);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMMoveToNextSection"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMMoveToNextSection(LLVMSectionIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMObjectFileIsSectionIteratorAtEnd"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMObjectFileIsSectionIteratorAtEnd(LLVMBinaryRef BR, LLVMSectionIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMObjectFileCopySectionIterator"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMSectionIteratorRef LLVMObjectFileCopySectionIterator(LLVMBinaryRef BR);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetValueName2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetValueName2(LLVMValueRef Val, out size_t Length);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetValueName2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetValueName2(LLVMValueRef Val, [MarshalAs( UnmanagedType.LPStr )] string Name, size_t NameLen);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMMetadataTypeInContext"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMMetadataTypeInContext(LLVMContextRef C);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMInt128TypeInContext"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMInt128TypeInContext(LLVMContextRef C);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMTokenTypeInContext"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMTokenTypeInContext(LLVMContextRef C);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMMDStringInContext2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMMDStringInContext2(LLVMContextRef C, [MarshalAs( UnmanagedType.LPStr )] string Str, size_t SLen);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMMDNodeInContext2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMMDNodeInContext2(LLVMContextRef C, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMMetadataRef[] MDs, size_t Count);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMCreateEnumAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMCreateEnumAttribute(LLVMContextRef C, uint KindID, global::System.UInt64 Val);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMCreateStringAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMCreateStringAttribute(LLVMContextRef C, [MarshalAs( UnmanagedType.LPStr )] string K, uint KLength, [MarshalAs( UnmanagedType.LPStr )] string V, uint VLength);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMCreateBasicBlockInContext"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMBasicBlockRef LLVMCreateBasicBlockInContext(LLVMContextRef C, [MarshalAs( UnmanagedType.LPStr )] string Name);

        /// <include file="../../ApiDocs/llvm-c/Disassembler.xml" path='LibLlvmAPI/Function[@name="LLVMCreateDisasm"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMDisasmContextRef LLVMCreateDisasm([MarshalAs( UnmanagedType.LPStr )] string TripleName, global::System.IntPtr DisInfo, int TagType, LLVMOpInfoCallback GetOpInfo, LLVMSymbolLookupCallback SymbolLookUp);

        /// <include file="../../ApiDocs/llvm-c/Disassembler.xml" path='LibLlvmAPI/Function[@name="LLVMCreateDisasmCPU"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMDisasmContextRef LLVMCreateDisasmCPU([MarshalAs( UnmanagedType.LPStr )] string Triple, [MarshalAs( UnmanagedType.LPStr )] string CPU, global::System.IntPtr DisInfo, int TagType, LLVMOpInfoCallback GetOpInfo, LLVMSymbolLookupCallback SymbolLookUp);

        /// <include file="../../ApiDocs/llvm-c/Disassembler.xml" path='LibLlvmAPI/Function[@name="LLVMCreateDisasmCPUFeatures"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMDisasmContextRef LLVMCreateDisasmCPUFeatures([MarshalAs( UnmanagedType.LPStr )] string Triple, [MarshalAs( UnmanagedType.LPStr )] string CPU, [MarshalAs( UnmanagedType.LPStr )] string Features, global::System.IntPtr DisInfo, int TagType, LLVMOpInfoCallback GetOpInfo, LLVMSymbolLookupCallback SymbolLookUp);

        /// <include file="../../ApiDocs/llvm-c/Disassembler.xml" path='LibLlvmAPI/Function[@name="LLVMSetDisasmOptions"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMSetDisasmOptions(LLVMDisasmContextRef DC, global::System.UInt64 Options);

        /// <include file="../../ApiDocs/llvm-c/Disassembler.xml" path='LibLlvmAPI/Function[@name="LLVMDisasmInstruction"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern size_t LLVMDisasmInstruction(LLVMDisasmContextRef DC, global::System.IntPtr Bytes, global::System.UInt64 BytesSize, global::System.UInt64 PC, ref global::System.Text.StringBuilder OutString, size_t OutStringSize);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetWeak"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMGetWeak(LLVMValueRef CmpXchgInst);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetWeak"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetWeak(LLVMValueRef CmpXchgInst, [MarshalAs( UnmanagedType.Bool )] bool IsWeak);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCalledValue"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetCalledValue(LLVMValueRef Instr);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAddCallSiteAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddCallSiteAttribute(LLVMValueRef C, LLVMAttributeIndex Idx, LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCallSiteAttributeCount"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMGetCallSiteAttributeCount(LLVMValueRef C, LLVMAttributeIndex Idx);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMRemoveCallSiteEnumAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveCallSiteEnumAttribute(LLVMValueRef C, LLVMAttributeIndex Idx, uint KindID);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMRemoveCallSiteStringAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveCallSiteStringAttribute(LLVMValueRef C, LLVMAttributeIndex Idx, [MarshalAs( UnmanagedType.LPStr )] string K, uint KLen);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetUnwindDest"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMBasicBlockRef LLVMGetUnwindDest(LLVMValueRef InvokeInst);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCurrentDebugLocation2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMGetCurrentDebugLocation2(LLVMBuilderRef Builder);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetCurrentDebugLocation2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetCurrentDebugLocation2(LLVMBuilderRef Builder, LLVMMetadataRef Loc);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMInsertExistingBasicBlockAfterInsertBlock"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInsertExistingBasicBlockAfterInsertBlock(LLVMBuilderRef Builder, LLVMBasicBlockRef BB);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCallSiteAttributes"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGetCallSiteAttributes(LLVMValueRef C, LLVMAttributeIndex Idx, [In][Out][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMAttributeRef[] Attrs);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCallSiteEnumAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMGetCallSiteEnumAttribute(LLVMValueRef C, LLVMAttributeIndex Idx, uint KindID);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetUnwindDest"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetUnwindDest(LLVMValueRef InvokeInst, LLVMBasicBlockRef B);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildInvoke2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildInvoke2(LLVMBuilderRef _0, LLVMTypeRef Ty, LLVMValueRef Fn, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMValueRef[] Args, uint NumArgs, LLVMBasicBlockRef Then, LLVMBasicBlockRef Catch, [MarshalAs( UnmanagedType.LPStr )] string Name);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildFreeze"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildFreeze(LLVMBuilderRef _0, LLVMValueRef Val, [MarshalAs( UnmanagedType.LPStr )] string Name);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildLoad2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildLoad2(LLVMBuilderRef _0, LLVMTypeRef Ty, LLVMValueRef PointerVal, [MarshalAs( UnmanagedType.LPStr )] string Name);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildAtomicCmpXchg"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildAtomicCmpXchg(LLVMBuilderRef B, LLVMValueRef Ptr, LLVMValueRef Cmp, LLVMValueRef New, LLVMAtomicOrdering SuccessOrdering, LLVMAtomicOrdering FailureOrdering, [MarshalAs( UnmanagedType.Bool )] bool SingleThread);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildStructGEP2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildStructGEP2(LLVMBuilderRef B, LLVMTypeRef Ty, LLVMValueRef Pointer, uint Idx, [MarshalAs( UnmanagedType.LPStr )] string Name);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMHasPersonalityFn"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMHasPersonalityFn(LLVMValueRef Fn);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAppendExistingBasicBlock"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAppendExistingBasicBlock(LLVMValueRef Fn, LLVMBasicBlockRef BB);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMAddAttributeAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddAttributeAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetAttributeCountAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMGetAttributeCountAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetEnumAttributeAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMGetEnumAttributeAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, uint KindID);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetStringAttributeAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMGetStringAttributeAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, [MarshalAs( UnmanagedType.LPStr )] string K, uint KLen);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMRemoveEnumAttributeAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveEnumAttributeAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, uint KindID);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetCallSiteStringAttribute"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMAttributeRef LLVMGetCallSiteStringAttribute(LLVMValueRef C, LLVMAttributeIndex Idx, [MarshalAs( UnmanagedType.LPStr )] string K, uint KLen);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildGEP2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildGEP2(LLVMBuilderRef B, LLVMTypeRef Ty, LLVMValueRef Pointer, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMValueRef[] Indices, uint NumIndices, [MarshalAs( UnmanagedType.LPStr )] string Name);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildInBoundsGEP2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildInBoundsGEP2(LLVMBuilderRef B, LLVMTypeRef Ty, LLVMValueRef Pointer, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMValueRef[] Indices, uint NumIndices, [MarshalAs( UnmanagedType.LPStr )] string Name);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildIntCast2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildIntCast2(LLVMBuilderRef _0, LLVMValueRef Val, LLVMTypeRef DestTy, [MarshalAs( UnmanagedType.Bool )] bool IsSigned, [MarshalAs( UnmanagedType.LPStr )] string Name);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMBuildCall2"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMBuildCall2(LLVMBuilderRef _0, LLVMTypeRef _1, LLVMValueRef Fn, [In][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMValueRef[] Args, uint NumArgs, [MarshalAs( UnmanagedType.LPStr )] string Name);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMLookupIntrinsicID"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMLookupIntrinsicID([MarshalAs( UnmanagedType.LPStr )] string Name, size_t NameLen);


        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetNormalDest"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMBasicBlockRef LLVMGetNormalDest(LLVMValueRef InvokeInst);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetNormalDest"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetNormalDest(LLVMValueRef InvokeInst, LLVMBasicBlockRef B);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMIsCleanup"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsCleanup(LLVMValueRef LandingPad);

        /// <include file="../../ApiDocs/llvm-c/ExecutionEngine.xml" path='LibLlvmAPI/Function[@name="LLVMCreateGenericValueOfInt"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMGenericValueRef LLVMCreateGenericValueOfInt(LLVMTypeRef Ty, ulong N, [MarshalAs( UnmanagedType.Bool )] bool IsSigned);


        /// <include file="../../ApiDocs/llvm-c/ExecutionEngine.xml" path='LibLlvmAPI/Function[@name="LLVMCreateGenericValueOfFloat"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMGenericValueRef LLVMCreateGenericValueOfFloat(LLVMTypeRef Ty, double N);

        /// <include file="../../ApiDocs/llvm-c/ExecutionEngine.xml" path='LibLlvmAPI/Function[@name="LLVMGenericValueIntWidth"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMGenericValueIntWidth(LLVMGenericValueRef GenValRef);

        /// <include file="../../ApiDocs/llvm-c/ExecutionEngine.xml" path='LibLlvmAPI/Function[@name="LLVMGenericValueToInt"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern ulong LLVMGenericValueToInt(LLVMGenericValueRef GenVal, [MarshalAs( UnmanagedType.Bool )] bool IsSigned);

        /// <include file="../../ApiDocs/llvm-c/ExecutionEngine.xml" path='LibLlvmAPI/Function[@name="LLVMGenericValueToFloat"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern double LLVMGenericValueToFloat(LLVMTypeRef TyRef, LLVMGenericValueRef GenVal);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocationOffset"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetRelocationOffset(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocationSymbol"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMSymbolIteratorRef LLVMGetRelocationSymbol(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocationTypeName"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )]
        public static extern string LLVMGetRelocationTypeName(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/libllvm-c/LibLlvmOrcJitBindings.xml" path='LibLlvmAPI/Function[@name="LibLLVMOrcGetSymbolAddress"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMErrorRef LibLLVMOrcGetSymbolAddress(LLVMOrcJITStackRef JITStack, out global::System.UInt64 RetAddr, [MarshalAs( UnmanagedType.LPStr )] string SymbolName, [MarshalAs( UnmanagedType.Bool )] bool ExportedSymbolsOnly);


        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocationValueString"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )]
        public static extern string LLVMGetRelocationValueString(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocationType"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetRelocationType(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSectionName"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetSectionName(LLVMSectionIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetRelocations"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMRelocationIteratorRef LLVMGetRelocations(LLVMSectionIteratorRef Section);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMIsRelocationIteratorAtEnd"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsRelocationIteratorAtEnd(LLVMSectionIteratorRef Section, LLVMRelocationIteratorRef RI);


        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMMoveToNextRelocation"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMMoveToNextRelocation(LLVMRelocationIteratorRef RI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSectionSize"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetSectionSize(LLVMSectionIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSectionContents"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.IntPtr LLVMGetSectionContents(LLVMSectionIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSymbolName"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetSymbolName(LLVMSymbolIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSymbolAddress"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetSymbolAddress(LLVMSymbolIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSymbolSize"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetSymbolSize(LLVMSymbolIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMObjectFileIsSymbolIteratorAtEnd"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMObjectFileIsSymbolIteratorAtEnd(LLVMBinaryRef BR, LLVMSymbolIteratorRef SI);

        /// <include file="../../ApiDocs/llvm-c/TargetMachine.xml" path='LibLlvmAPI/Function[@name="LLVMCreateTargetDataLayout"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTargetDataRef LLVMCreateTargetDataLayout(LLVMTargetMachineRef T);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/IPO.xml" path='LibLlvmAPI/Function[@name="LLVMAddInternalizePassWithMustPreservePredicate"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddInternalizePassWithMustPreservePredicate(LLVMPassManagerRef PM, global::System.IntPtr Context, global::System.IntPtr MustPreserve);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddDCEPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddDCEPass(LLVMPassManagerRef PM);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddNewGVNPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddNewGVNPass(LLVMPassManagerRef PM);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddLoopUnrollAndJamPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddLoopUnrollAndJamPass(LLVMPassManagerRef PM);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddLowerAtomicPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddLowerAtomicPass(LLVMPassManagerRef PM);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddEarlyCSEMemSSAPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddEarlyCSEMemSSAPass(LLVMPassManagerRef PM);


        /// <include file="../../../ApiDocs/llvm-c/Transforms/Scalar.xml" path='LibLlvmAPI/Function[@name="LLVMAddLowerConstantIntrinsicsPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddLowerConstantIntrinsicsPass(LLVMPassManagerRef PM);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Vectorize.xml" path='LibLlvmAPI/Function[@name="LLVMAddLoopVectorizePass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddLoopVectorizePass(LLVMPassManagerRef PM);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSectionContainsSymbol"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMGetSectionContainsSymbol(LLVMSectionIteratorRef SI, LLVMSymbolIteratorRef Sym);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMMoveToContainingSection"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMMoveToContainingSection(LLVMSectionIteratorRef Sect, LLVMSymbolIteratorRef Sym);

        /// <include file="../../ApiDocs/llvm-c/Object.xml" path='LibLlvmAPI/Function[@name="LLVMGetSectionAddress"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetSectionAddress(LLVMSectionIteratorRef SI);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Vectorize.xml" path='LibLlvmAPI/Function[@name="LLVMAddSLPVectorizePass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddSLPVectorizePass(LLVMPassManagerRef PM);

        /// <include file="../../ApiDocs/llvm-c/TargetMachine.xml" path='LibLlvmAPI/Function[@name="LLVMNormalizeTargetTriple"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )]
        public static extern string LLVMNormalizeTargetTriple([MarshalAs( UnmanagedType.LPStr )] string triple);

        /// <include file="../../ApiDocs/llvm-c/TargetMachine.xml" path='LibLlvmAPI/Function[@name="LLVMGetDefaultTargetTriple"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )]
        public static extern string LLVMGetDefaultTargetTriple();

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetEnumAttributeKindForName"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMGetEnumAttributeKindForName([MarshalAs( UnmanagedType.LPStr )] string Name, size_t SLen);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMIsStringAttribute"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsStringAttribute(LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetStringAttributeKind"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetStringAttributeKind(LLVMAttributeRef A, out uint Length);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetGlobalIFuncResolver"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetGlobalIFuncResolver(LLVMValueRef IFunc);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMRemoveGlobalIFunc"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveGlobalIFunc(LLVMValueRef IFunc);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGlobalCopyAllMetadata"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueMetadataEntry LLVMGlobalCopyAllMetadata(LLVMValueRef Value, out size_t NumEntries);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetEnumAttributeKind"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMGetEnumAttributeKind(LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetStringAttributeValue"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetStringAttributeValue(LLVMAttributeRef A, out uint Length);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetEnumAttributeValue"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::System.UInt64 LLVMGetEnumAttributeValue(LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMIsEnumAttribute"]/*' />
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsEnumAttribute(LLVMAttributeRef A);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMSetGlobalIFuncResolver"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetGlobalIFuncResolver(LLVMValueRef IFunc, LLVMValueRef Resolver);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGlobalSetMetadata"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGlobalSetMetadata(LLVMValueRef Global, uint Kind, LLVMMetadataRef MD);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMGetAttributesAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGetAttributesAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, [In][Out][MarshalAs( UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt )] LLVMAttributeRef[] Attrs);

        /// <include file="../../ApiDocs/llvm-c/Core.xml" path='LibLlvmAPI/Function[@name="LLVMRemoveStringAttributeAtIndex"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveStringAttributeAtIndex(LLVMValueRef F, LLVMAttributeIndex Idx, [MarshalAs( UnmanagedType.LPStr )] string K, uint KLen);

        /// <include file="../../../ApiDocs/llvm-c/Transforms/Utils.xml" path='LibLlvmAPI/Function[@name="LLVMAddAddDiscriminatorsPass"]/*' />
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddAddDiscriminatorsPass(LLVMPassManagerRef PM);
    }
}
