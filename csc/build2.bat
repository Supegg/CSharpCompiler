echo off

if exist WinForm.exe del WinForm.exe

rem build a WinForm application
csc /target:winexe /out:WinForm.exe ^
/win32icon:..\CSharpCompiler\Eva.ico ^
..\CSharpCompiler\Program.cs ^
..\CSharpCompiler\Compiler.cs ^
..\CSharpCompiler\Compiler.Designer.cs ^
..\CSharpCompiler\FormMain.cs ^
..\CSharpCompiler\FormMain.Designer.cs ^
..\CSharpCompiler\Properties\AssemblyInfo.cs

start WinForm.exe
