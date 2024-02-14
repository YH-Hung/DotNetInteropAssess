#include "library.h"

#include <iostream>

void hello(char *interStr) {
    std::cout << "Hello, Native C++ lib!" << std::endl
    << "String from managed: " << interStr << std::endl;
}

void append_string_ansi(char *dest, const char *src, std::size_t n) {
    std::cout << "Length in C++: " << strlen(src) << std::endl;
    memmove(dest, src, n);
}

void append_string_unicode(wchar_t *dest, const wchar_t *src, std::size_t n) {
    std::wcout << "Length in C++: " << wcslen(src) << std::endl;
    wmemmove(dest, src, n);
}

void append_string_byte(char *dest, const char *src, std::size_t n) {
    std::cout << "Length in C++: " << strlen(src) << std::endl;
    memmove(dest, src, n);
}
