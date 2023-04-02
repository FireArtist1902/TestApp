#include<iostream>
#include"Func.h"


bool compare(std::string a, char b[])
{
	int count = 0;
	for (int i = 0; i < a.length(); i++)
	{
		if (a[i] == b[i])
		{
			count++;
		}
	}
	if (count == a.length())
	{
		return true;
	}
	else
	{
		return false;
	}
}


