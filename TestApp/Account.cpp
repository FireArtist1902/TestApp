#include "Account.h"
#include"Func.h"
#include "Menu.h"
#include <fstream>
#include <iostream>
#include <string>

void Account::Regist()
{
	std::string l, p;
	std::string check, checkAdm;
	std::cout<< "Логин: ";
	std::cin >> l;
	std::cout << "Пароль: ";
	std::cin >> p;
	u.SetLogin(l);
	u.SetPassword(p);
	std::ifstream ff;
	ff.open("users.txt", std::ios::app);
	std::getline(ff, check);
	ff.close();
	ff.open("admin.txt", std::ios::app);
	std::getline(ff, checkAdm);
	ff.close();

	if (check == "" and checkAdm == "")
	{
		std::ofstream f;
		f.open("admin.txt", std::ios::app);
		if (f.is_open())
		{
			f << l << '\n' << p << '\n';
		}
		f.close();
		system("cls");
		admMenu();
	}
	else
	{
		if (check == "" and checkAdm != "")
		{


			std::ifstream fi;
			fi.open("users.txt", std::ios::app);
			if (fi.is_open())
			{
				while (!fi.eof())
				{
					std::string log;
					std::string pas;
					std::getline(fi, log, '\n');
					std::getline(fi, pas, '\n');
					while (l == log and p != pas)
					{
						std::cout << "Пользователь я таким именем уже существует, пожалуйста смените свое имя" << std::endl;
						std::string l, p;
						std::cout << "Логин: ";
						std::cin >> l;
						std::cout << "Пароль: ";
						std::cin >> p;
					}
					if (l == log and p == pas)
					{
						std::cout << "Такой аккаунт уже существует, войдите в Ваш аккаунт" << std::endl;
						Login();
						break;
						fi.close();
					}
				}
			}
			fi.close();
			std::ofstream f;
			f.open("users.txt", std::ios::app);
			if (f.is_open())
			{
				f << u.GetLogin() << "\n" << u.GetPassword() << "\n";
			}
			f.close();
			system("cls");
			menu(u.GetLogin());
		}
	}
	

}
void Account::Login()
{
	bool reg = true;
	std::string l, p;
	std::ifstream f;
	std::string la, pa;
	std::cout << "Логин: ";
	std::cin >> l;
	std::cout << "Пароль: ";
	std::cin >> p;
	f.open("admin.txt", std::ios::app);
	if (f.is_open())
	{
			std::getline(f, la, '\n');
			std::getline(f, pa, '\n');
	}
	f.close();
	if (l == la and p == pa )
	{
		system("cls");
		admMenu();
	}
	else
	{
		f.open("users.txt", std::ios::app);
		if (f.is_open())
		{
			while (!f.eof())
			{
				std::string log;
				std::string pas;
				getline(f, log, '\n');
				getline(f, pas, '\n');
				if (l == log and p == pas)
				{
					system("cls");
					f.close();
					reg = false;
					menu(l);
					break;
				}
				else
				{
					reg = true;
				}
			}
		}
		f.close();
		if (reg)
		{
			std::cout << "Такого аккаунта не существует, пожалуйста зпройдите процедуру регистрации" << std::endl;
			Regist();
		}
		menu(l);
	}

}
Account::Account()
{
} 