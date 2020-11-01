#pragma once


#ifdef DLLDIR_EX
#define DLLDIR  __declspec(dllexport)   // export DLL information

#else
#define DLLDIR  __declspec(dllimport)   // import DLL information

#endif 

extern "C"
{
	__declspec(dllexport) int __stdcall MyCoolMethod();
}