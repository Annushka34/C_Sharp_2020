#include"Header.h"
#include<iostream>




__declspec(dllexport)
int __stdcall MyCoolMethod()
{
	std::cout << "Hello World of DLL 2" << std::endl;
	return 100;
}