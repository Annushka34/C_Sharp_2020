#include<iostream>
#include<conio.h>
using namespace std;

void main()
{
	cout << "Hello";
	ClassLibrary1::Class1^ cl = gcnew ClassLibrary1::Class1();
	cl->MyMethod();
	_getch();
}