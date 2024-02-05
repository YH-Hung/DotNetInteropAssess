#include "library.h"

#include <iostream>

void hello(char *interStr) {
    std::cout << "Hello, Native C++ lib!" << std::endl
    << "String from managed: " << interStr << std::endl;
}

void append_String(char *dest, const char *src, unsigned long n) {
    std::cout << "Length in C++: " << strlen(src) << std::endl;
    memmove(dest, src, n);
}
