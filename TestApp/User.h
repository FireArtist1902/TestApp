#pragma once
#include <iostream>
class User
{
	std::string login;
	std::string password;
public:
	User();
	~User();
	void SetLogin(std::string l);
	void SetPassword(std::string p);
	std::string GetPassword();
	std::string GetLogin();
};

