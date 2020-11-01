#include<Windows.h>
//#include"D:\ÿ¿√\Ò#\examples\Lesson16_Assambly\DllClasSharp\bin\Debug\DllClasSharp.dll"

#using <mscorlib.dll>
using namespace System::Collections;
using namespace System;
//using namespace Lesson16_Assambly;

void main()
{
	Console::WriteLine("Hello, C++.NET World!");

	String ^str = Console::ReadLine();
	Console::Write("Output: " + str);
	DllMy::Class1 ^cl = gcnew DllMy::Class1();
	cl->Hello();
	system("pause");
}