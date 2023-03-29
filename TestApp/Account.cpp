#include "Account.h"
#include"Func.h"
#include <fstream>
void Account::Regist(std::string l, std::string p)
{
	u.SetLogin(l);
	u.SetPassword(p);
	std::ofstream f;
	f.open("users.txt", std::ios::app);
	if (f.is_open())
	{
		f << Cezar(u.GetLogin())<< "\n" << Cezar(u.GetPassword()) << "\n";
	}
	f.close();
}
void Account::Entrance()
{
	std::string l, p;
	std::fstream f("users.txt", std::ios::app);
	std::cout << "Login: ";
	std::cin >> l;
	std::cout << "Password: ";
	std::cin >> p;
	Cezar(l);
	Cezar(p);
	f.open("users.txt");
	if (f.is_open())
	{
		while (!f.eof())
		{
			std::string log;
			std::string pass;
			f >> log;
			f >> pass;
			if(l == log and p == pass)
			{
				std::cout << "Вы успешно вошли " << std::endl;
				break;
			}
		}
	}
	f.close();
	std::cout<<"Вы успешно зарегистрированы, ваши данные сохранены" << std::endl;
	Regist(l, p);

}
Account::Account()
{
} 