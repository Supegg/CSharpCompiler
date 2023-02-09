echo off

if exist Starter.exe del Starter.exe

rem build a WinForm application, ref a library
csc @start.rsp Starter.cs

start Starter.exe
