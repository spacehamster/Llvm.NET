<#
.SYNOPSIS
    Builds the native code Extended LLVM C API DLL along with the interop .NET assembly for it

.NOTE

#>
Param(
    [string]$Configuration="Release",
    [switch]$AllowVsPreReleases,
    [switch]$NoClean
)

pushd $PSScriptRoot
$oldPath = $env:Path
try
{
    $dxcCommit = "ac60ae1f4d7840678382f4959d4c04632fd35b5e"
    $repoPath = "Downloads/DXC"    
    #In source tree builds not supported as Directory.Build.props causes DXC build errors
    $buildPath = "..\DXCBuild"
    if(!(Test-Path -PathType Container $repoPath))
    {
        Write-Debug "Cloning DXC"
        git clone https://github.com/microsoft/DirectXShaderCompiler $repoPath
        Write-Debug "Resetting to commit $dxcCommit"
        Push-Location $repoPath
        git reset --hard $dxcCommit
        Pop-Location
    }
    if(!(Test-Path -PathType Container $buildPath))
    {
        new-item $buildPath -itemtype directory
        $buildPath = Resolve-Path -Path $buildPath
        $repoPath = Resolve-Path -Path $repoPath
        & .\Build-DXC-Batch $repoPath $buildPath
    }

    $destPath = "llvm"
    $dxcLib = "DXCUtil"
    $dxcBin = $buildPath
    $dxcSrc = $repoPath
    Write-Debug "Cleaning $($destPath)"
    Remove-Item -Recurse -Force $destPath -ErrorAction Ignore
    Write-Debug "Creating $($destPath)"
    Write-Debug "Copying Items"
    Copy-Item -Path "$($dxcBin)\Release\lib" -Recurse -Destination "$($destPath)\x64-Release\Release\lib" -Container
    Copy-Item -Path "$($dxcBin)\Debug\lib" -Recurse -Destination "$($destPath)\x64-Debug\Debug\lib" -Container
    Copy-Item -Path "$($dxcSrc)\include" -Recurse -Destination "$($destPath)\include" -Container
    Copy-Item -Path "$($dxcBin)\include\llvm\Config\*" -Recurse -Destination "$($destPath)\include\llvm\Config" -Container
    Copy-Item -Path "$($dxcBin)\include\llvm\Support\DataTypes.h" -Destination "$($destPath)\include\llvm\Support\DataTypes.h"
    Copy-Item -Path "$($dxcBin)\include\llvm\IR\Intrinsics.gen" -Destination "$($destPath)\include\llvm\IR\Intrinsics.gen"
    Copy-Item -Path "$($dxcLib)\Llvm-Libs.props" -Destination "$($destPath)\Llvm-Libs.props"
    Copy-Item -Path "$($dxcLib)\Llvm-Libs.targets" -Destination "$($destPath)\Llvm-Libs.targets"
    Copy-Item -Path "$($dxcLib)\llvm-version.json" -Destination "$($destPath)\llvm-version.json"

    Write-Debug "Finished building DXC"
}
catch
{
    Write-Error $_.Exception.Message
}
finally
{
    popd
    $env:Path = $oldPath
}