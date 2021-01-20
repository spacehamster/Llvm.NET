# Setup project.
PROJECT(Ubiquity.NET.Llvm.Interop VERSION 1.0.0.0 LANGUAGES CSharp)

# Setup project to use C# utilities.
INCLUDE(CSharpUtilities)

file(GLOB_RECURSE SOURCES RELATIVE ${CMAKE_SOURCE_DIR} "src/*.cs")

# Add shared library project.
ADD_LIBRARY(Ubiquity.NET.Llvm.Interop SHARED
    "Properties/AssemblyInfo.cs"
    "CustomStringMarshalerBase.cs"
    "DisposableAction.cs"
    "ILibLlvm.cs"
    "IntPtrExtensions.cs"
    "Library.cs"
    "LlvmException.cs"
    "LLVMObjectRef.cs"
    "LLVMStatus.cs"
    "NativeMethods.cs"
    "size_t.cs"
    "StringNormalizer.cs"
    "StrippedFunctionException.cs"
    "UnexpectedNullHandleException.cs"
    "WrappedNativeCallback.cs"
    "Stripped/LibLLVMDwarfSourceLanguage.cs"
    "Stripped/LLVMAttributeIndex.cs"
    "Stripped/LLVMBinaryType.cs"
    "Stripped/LLVMModuleFlagBehavior.cs"
    "Stripped/LLVMUnnamedAddr.cs"
    "Stripped/StrippedMethods.cs"
    ${SOURCES}
)

# Set designer and XAML properties.
CSHARP_SET_DESIGNER_CS_PROPERTIES(
    "Properties/AssemblyInfo.cs"
)

# NOTE: If you want to restore NuGet packages (see README.md), do it here!

# Setup the .NET Framework version.
SET_PROPERTY(TARGET CSharpLib PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.7.2")

# Setup the default assembly references.
SET_PROPERTY(TARGET CSharpLib PROPERTY VS_DOTNET_REFERENCES
	"System"
    "System.Core"
)

