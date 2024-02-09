using System.Buffers;
using System.Runtime.InteropServices;
using System.Text;

const string dllPath = "/Users/yinghanhung/Projects/dotnet/NativeInteropAssess/NativeDll/cmake-build-debug/libNativeDll.dylib";

// Mac ANSI = UTF8
[DllImport(dllPath, CharSet = CharSet.Ansi)]
static extern void hello(string toShow);

// Mac ANSI = UTF8
[DllImport(dllPath, CharSet = CharSet.Ansi)]
static extern void append_string_ansi([Out] char[] dest, string src, uint n);

[DllImport(dllPath, CharSet = CharSet.Unicode)]
static extern void append_string_unicode([Out] char[] dest, string src, uint n);

[DllImport(dllPath)]
static extern void append_string_byte([Out] byte[] dest, byte[] src, uint n);

hello("A li Bu go ミッキー 阿里不哥 鱻龘");

var utf8 = Encoding.UTF8;

const string sample = "脫脫不花 is a モンゴルの大カーン";
int length = utf8.GetByteCount(sample);

char[] buffer = ArrayPool<char>.Shared.Rent(length + 1);
char[] bufferUnicode = ArrayPool<char>.Shared.Rent(sample.Length + 1);
byte[] bufferRaw = ArrayPool<byte>.Shared.Rent(length + 1);

append_string_ansi(buffer, sample, (uint)length);
append_string_unicode(bufferUnicode, sample, (uint)sample.Length);
append_string_byte(bufferRaw, utf8.GetBytes(sample), (uint)length);

Console.WriteLine("Byte count of utf8: {0}", length);
Console.WriteLine("Sample string length: {0}", sample.Length);
Console.WriteLine("Mac ANSI marshal: {0}", new string(buffer));
Console.WriteLine("Mac Unicode marshal: {0}", new string(bufferUnicode));
Console.WriteLine("Mac Direct Byte: {0}", utf8.GetString(bufferRaw));