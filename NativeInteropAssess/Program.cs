// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

[DllImport("/Users/yinghanhung/Projects/dotnet/NativeInteropAssess/NativeDll/cmake-build-debug/libNativeDll.dylib")]
static extern void hello();

hello();
Console.WriteLine("Hello, World!");