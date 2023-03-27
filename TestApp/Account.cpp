#include "Account.h"
#include"Func.h"
#include <fstream>
#include <Windows.h>
void Account::Regist()
{
	std::string l, p;
	std::cout<<"Login: ";
	std::cin >> l;
	u.SetLogin(l);
	std::cout << "Password: ";
	std::cin >> p;
	u.SetPassword(p);
	std::ofstream f;
	f.open("users.txt");
	if (f.is_open())
	{
		SetConsoleCP(1251);
		f << Cezar(u.GetLogin())<< "\n" << Cezar(u.GetPassword()) << "\n";
		SetConsoleCP(866);
	}
	f.close();
}
Account::Account()
{
} 