@echo off
SET SCRIPT_DIR=%~dp0
echo DXC source=%1
echo Build Dir=%2
CALL %1\utils\hct\hctstart -x64 %1 %2
CD %SCRIPT_DIR%
echo Finished hctstart
CALL %1\utils\hct\hctbuild -rel
echo Finished release build
CD %SCRIPT_DIR%
CALL %1\utils\hct\hctbuild
echo Finished debug build
