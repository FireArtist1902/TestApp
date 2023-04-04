#include <iostream>
#include <fstream>
#include <string>
#include "Menu.h"
#include "Account.h"
#include "Test.h"
void menu(std::string name)
{
	std::string menu;
	std::cout << "Напишите команду, которая должна выполниться сейчас (h для подсказки)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		std::cout << "test - тематики тестов" << std::endl;
		std::cout << "stat - статистика пользователя" << std::endl;
		std::cin >> menu;
	}
	if (menu == "test")
	{
		system("cls");
		testUser(name);
	}
	if (menu == "stat")
	{
		system("cls");
		std::ifstream f(name + ".txt", std::ios::app);
		if (f.is_open())
		{
			std::cout << "Статистика пользователя " << name << std::endl;
			while (!f.eof())
			{
				std::string stat;
				std::getline(f, stat, '\n');
				std::cout << stat << std::endl;
			}
		}
	}
}

void menuStart()
{
	Account a;
	std::string menu;
	std::cout << "Что Вы хотите сделать? (h для подсказки)" << std::endl;
	std::cin >> menu;

	if (menu == "h")
	{
		std::system("cls");
		std::cout << "login - вход в систему" << std::endl;
		std::cout << "reg - регистрация" << std::endl;
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
	std::string menu;
	std::cout << "Что Вы хотите сделать? (h для подсказки)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		system("cls");
		std::cout << "create - создает тест" << std::endl;
		std::cout << "clearStat - очищает статистику выбраного пользователя" << std::endl;
		std::cin >> menu;
	}
	if (menu == "create")
	{
		system("cls");

		testMenu();
	}
	else
	{
		if (menu == "clearStat")
		{
			system("cls");
			std::string name;
			std::cout << "Введите имя пользователя статистику котторого Вы хотите удалить" << std::endl;
			std::cin >> name;
			std::ofstream f;
			f.open(name + ".txt");
			f.close();
		}
	}
}

void testMenu()
{
	Test t;
	system("cls");
	t.addTest();
}

void testUser(std::string name)
{
	int mark = 0, count = 0;
	std::string sub;
	std::cout << "Введите предмет" << std::endl;
	std::cin >> sub;
	std::ifstream f;
	system("cls");
	f.open(sub + ".txt", std::ios::app);
	if(f.is_open())
	{
		while (!f.eof())
		{
			std::string q;
			std::string a;
			std::string ans;
			std::getline(f, q, '\n');
			std::getline(f, a, '\n');
			std::cout << q << std::endl;
			std::cout << "Ваш ответ" << std::endl;
			std::cin >> ans;
			if (ans == a)
			{
				system("cls");
				std::cout << "Правильный ответ" << std::endl;
				system("pause");
				system("cls");
				count++;
				mark++;
			}
			else
			{
				system("cls");
				std::cout << "Ответ не правильный" << std::endl;
				system("pause");
				system("cls");
				count++;
			}
		}
	}
	else
	{
		std::cout << "Не правильное название предмета" << std::endl;
	}
	std::cout << "Ваша оценка" << mark << "/" << count << std::endl;
	std::ofstream of(name + ".txt", std::ios::app);
	if (of.is_open())
	{
		of << mark << "/" << count;
	}
	of.close();
}
