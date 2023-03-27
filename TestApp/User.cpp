#include "User.h"
void User::SetLogin(std::string l)
{
	this->login = l;
}

void User::SetPassword(std::string p)
{
	this->password = p;
}

std::string User::GetLogin()
{
	return this->login;
}

std::string User::GetPassword()
{
	return this->password;
}
User::User()
{
	
}
User::~User()
{
	login.clear();
	password.clear();
}