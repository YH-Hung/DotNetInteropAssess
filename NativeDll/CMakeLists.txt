cmake_minimum_required(VERSION 3.28)
project(NativeDll)

set(CMAKE_CXX_STANDARD 17)

add_library(NativeDll SHARED library.cpp)
