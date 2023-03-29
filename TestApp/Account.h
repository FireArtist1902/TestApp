#pragma once
#include <iostream>
#include "User.h"
class Account
{
	User u;
public:
	Account();
	void Regist(std::string l, std::string p);
	void Entrance();
	
};