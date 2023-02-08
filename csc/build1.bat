echo off

if exist Hello.exe del Hello.exe

rem build a Console application
csc /win32icon:..\CSharpCompiler\Eva.ico /target:exe /out:Hello.exe HelloWorld.cs 

start Hello.exe
