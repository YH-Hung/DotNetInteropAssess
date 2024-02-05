#ifndef NATIVEDLL_LIBRARY_H
#define NATIVEDLL_LIBRARY_H

extern "C" void hello(char *interStr);

extern "C" void append_String(char *dest, const char *src, unsigned long n);

#endif //NATIVEDLL_LIBRARY_H
