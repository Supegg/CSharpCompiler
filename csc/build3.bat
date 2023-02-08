echo off

if exist Starter.exe del Starter.exe

rem build a WinForm application, ref a library
csc /target:winexe /out:Starter.exe ^
/r:WinForm.exe ^
/win32icon:..\CSharpCompiler\Eva.ico ^
Starter.cs 

start Starter.exe
