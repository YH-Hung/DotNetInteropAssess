using System.Buffers;
using System.Runtime.InteropServices;
using System.Text;

const string dllPath = "/Users/yinghanhung/Projects/dotnet/NativeInteropAssess/NativeDll/cmake-build-debug/libNativeDll.dylib";

// Mac ANSI = UTF8
[DllImport(dllPath, CharSet = CharSet.Ansi)]
static extern void hello(string toShow);

// Mac ANSI = UTF8
[DllImport(dllPath, CharSet = CharSet.Ansi)]
static extern void append_String([Out] char[] dest, string src, uint n);

hello("A li Bu go ミッキー 阿里不哥 鱻龘");

var utf8 = Encoding.UTF8;

const string sample = "脫脫不花 is a モンゴルの大カーン";
int length = utf8.GetByteCount(sample);

char[] buffer = ArrayPool<char>.Shared.Rent(length + 1);
append_String(buffer, sample, (uint)length);

Console.WriteLine("Byte count of utf8: {0}", length);
Console.WriteLine("Sample string length: {0}", sample.Length);
Console.WriteLine(new string(buffer));