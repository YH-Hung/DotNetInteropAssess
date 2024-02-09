#ifndef NATIVEDLL_LIBRARY_H
#define NATIVEDLL_LIBRARY_H

extern "C" {
    void hello(char *interStr);
    void append_string_ansi(char *dest, const char *src, unsigned long n);
    void append_string_unicode(wchar_t *dest, const wchar_t *src, unsigned long n);
    void append_string_byte(char *dest, const char *src, unsigned long n);
}

#endif //NATIVEDLL_LIBRARY_H
