#include <iostream>
#include "Menu.h"
#include "Account.h"
void menu()
{
	Account a;
	std::string menu;
	std::cout << "Ќапишите команду, котора€ должна выполнитьс€ сейчас (h дл€ подсказки)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		std::cout << "test - тематики тестов" << std::endl;
		std::cout << "stat - статистика" << std::endl;
	}
}
void menuStart()
{
	Account a;
	std::string menu;
	std::cout << "Ќапишите команду, котора€ должна выполнитьс€ сейчас (h дл€ подсказки)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		std::system("cls");
		std::cout << "login - вход в систему" << std::endl;
		std::cout << "reg - регистраци€" << std::endl;
		std::cin >> menu;
	}
	if (menu == "reg")
	{
		system("cls");
		a.Regist();
	}
	else
	{
		if (menu == "login")
		{
			std::system("cls");
			a.Login();
		}
	}
}

void admMenu()
{
	std::cout << "“ы крутой" << std::endl;
}
