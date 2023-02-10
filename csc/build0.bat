echo off

msbuild ..\CSharpCompiler.sln

copy ..\CSharpCompiler\bin\Debug\CSharpCompiler.exe CSharpCompiler.exe

start CSharpCompiler.exe
