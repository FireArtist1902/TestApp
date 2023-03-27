#include<iostream>
#include"Func.h"

std::string Cezar(std::string a)
{
	for (int i = 0; i < a.length(); i++)
	{
		a[i]++;
	}
	return a;
}