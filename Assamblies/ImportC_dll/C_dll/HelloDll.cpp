//#include "StdAfx.h"
#include "HelloDLL.h"
#include <iostream>

using namespace std;

__declspec(dllexport)
void __stdcall hello()
{
	cout << "Hello World of DLL" << endl;
}
__declspec(dllexport)
void  __stdcall helloStatic()
{
	cout << "Hello World of DLL static" << endl;
}

__declspec(dllexport)
int  __stdcall countSum(int a, int b)
{
	return a + b;
}