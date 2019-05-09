// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 2.17941.31104.49410
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;

namespace Llvm.NET.Interop
{
    /**
     * @defgroup LLVMCTarget Target information
     * @ingroup LLVMC
     *
     * @{
     */
    [GeneratedCode("LlvmBindingsGenerator","2.17941.31104.49410")]
    public enum LLVMByteOrdering : global::System.Int32
    {
        LLVMBigEndian = 0,
        LLVMLittleEndian = 1,
    }

    public static partial class NativeMethods
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64TargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430TargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeNVPTXTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86TargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeXCoreTargetInfo(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64Target(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430Target(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeNVPTXTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86Target(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeXCoreTarget(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64TargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430TargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeNVPTXTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86TargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeXCoreTargetMC(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64AsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430AsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeNVPTXAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86AsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeXCoreAsmPrinter(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64AsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430AsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyAsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86AsmParser(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAArch64Disassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAMDGPUDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeARMDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeBPFDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeHexagonDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeLanaiDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMipsDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeMSP430Disassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializePowerPCDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSparcDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeSystemZDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeWebAssemblyDisassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeX86Disassembler(  );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeXCoreDisassembler(  );

        /** LLVMInitializeAllTargetInfos - The main program should call this function if
            it wants access to all available targets that LLVM is configured to
            support. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllTargetInfos(  );

        /** LLVMInitializeAllTargets - The main program should call this function if it
            wants to link in all available targets that LLVM is configured to
            support. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllTargets(  );

        /** LLVMInitializeAllTargetMCs - The main program should call this function if
            it wants access to all available target MC that LLVM is configured to
            support. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllTargetMCs(  );

        /** LLVMInitializeAllAsmPrinters - The main program should call this function if
            it wants all asm printers that LLVM is configured to support, to make them
            available via the TargetRegistry. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllAsmPrinters(  );

        /** LLVMInitializeAllAsmParsers - The main program should call this function if
            it wants all asm parsers that LLVM is configured to support, to make them
            available via the TargetRegistry. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllAsmParsers(  );

        /** LLVMInitializeAllDisassemblers - The main program should call this function
            if it wants all disassemblers that LLVM is configured to support, to make
            them available via the TargetRegistry. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMInitializeAllDisassemblers(  );

        /** LLVMInitializeNativeTarget - The main program should call this function to
            initialize the native target corresponding to the host.  This is useful
            for JIT applications to ensure that the target gets linked in correctly. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMStatus LLVMInitializeNativeTarget(  );

        /** LLVMInitializeNativeTargetAsmParser - The main program should call this
            function to initialize the parser for the native target corresponding to the
            host. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMStatus LLVMInitializeNativeAsmParser(  );

        /** LLVMInitializeNativeTargetAsmPrinter - The main program should call this
            function to initialize the printer for the native target corresponding to
            the host. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMStatus LLVMInitializeNativeAsmPrinter(  );

        /** LLVMInitializeNativeTargetDisassembler - The main program should call this
            function to initialize the disassembler for the native target corresponding
            to the host. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMStatus LLVMInitializeNativeDisassembler(  );

        /**
         * Obtain the data layout for a module.
         *
         * @see Module::getDataLayout()
         */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTargetDataRef LLVMGetModuleDataLayout( LLVMModuleRef M );

        /**
         * Set the data layout for a module.
         *
         * @see Module::setDataLayout()
         */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetModuleDataLayout( LLVMModuleRef M, LLVMTargetDataRef DL );

        /** Creates target data from a target layout string.
            See the constructor llvm::DataLayout::DataLayout. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTargetDataRef LLVMCreateTargetData( [MarshalAs( UnmanagedType.LPStr )]string StringRep );

        /** Adds target library information to a pass manager. This does not take
            ownership of the target library info.
            See the method llvm::PassManagerBase::add. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddTargetLibraryInfo( LLVMTargetLibraryInfoRef TLI, LLVMPassManagerRef PM );

        /** Converts target data to a target layout string. The string must be disposed
            with LLVMDisposeMessage.
            See the constructor llvm::DataLayout::DataLayout. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( DisposeMessageMarshaler ) )]
        public static extern string LLVMCopyStringRepOfTargetData( LLVMTargetDataRef TD );

        /** Returns the byte order of a target, either LLVMBigEndian or
            LLVMLittleEndian.
            See the method llvm::DataLayout::isLittleEndian. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern global::Llvm.NET.Interop.LLVMByteOrdering LLVMByteOrder( LLVMTargetDataRef TD );

        /** Returns the pointer size in bytes for a target.
            See the method llvm::DataLayout::getPointerSize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMPointerSize( LLVMTargetDataRef TD );

        /** Returns the pointer size in bytes for a target for a specified
            address space.
            See the method llvm::DataLayout::getPointerSize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMPointerSizeForAS( LLVMTargetDataRef TD, uint AS );

        /** Returns the integer type that is the same size as a pointer on a target.
            See the method llvm::DataLayout::getIntPtrType. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMIntPtrType( LLVMTargetDataRef TD );

        /** Returns the integer type that is the same size as a pointer on a target.
            This version allows the address space to be specified.
            See the method llvm::DataLayout::getIntPtrType. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMIntPtrTypeForAS( LLVMTargetDataRef TD, uint AS );

        /** Returns the integer type that is the same size as a pointer on a target.
            See the method llvm::DataLayout::getIntPtrType. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMIntPtrTypeInContext( LLVMContextRef C, LLVMTargetDataRef TD );

        /** Returns the integer type that is the same size as a pointer on a target.
            This version allows the address space to be specified.
            See the method llvm::DataLayout::getIntPtrType. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMTypeRef LLVMIntPtrTypeForASInContext( LLVMContextRef C, LLVMTargetDataRef TD, uint AS );

        /** Computes the size of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeSizeInBits. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern ulong LLVMSizeOfTypeInBits( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the storage size of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeStoreSize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern ulong LLVMStoreSizeOfType( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the ABI size of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeAllocSize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern ulong LLVMABISizeOfType( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the ABI alignment of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeABISize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMABIAlignmentOfType( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the call frame alignment of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeABISize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMCallFrameAlignmentOfType( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the preferred alignment of a type in bytes for a target.
            See the method llvm::DataLayout::getTypeABISize. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMPreferredAlignmentOfType( LLVMTargetDataRef TD, LLVMTypeRef Ty );

        /** Computes the preferred alignment of a global variable in bytes for a target.
            See the method llvm::DataLayout::getPreferredAlignment. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMPreferredAlignmentOfGlobal( LLVMTargetDataRef TD, LLVMValueRef GlobalVar );

        /** Computes the structure element that contains the byte offset for a target.
            See the method llvm::StructLayout::getElementContainingOffset. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMElementAtOffset( LLVMTargetDataRef TD, LLVMTypeRef StructTy, ulong Offset );

        /** Computes the byte offset of the indexed struct element for a target.
            See the method llvm::StructLayout::getElementContainingOffset. */
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern ulong LLVMOffsetOfElement( LLVMTargetDataRef TD, LLVMTypeRef StructTy, uint Element );

    }
}