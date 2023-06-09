#include <iostream>
#include <fstream>
#include <string>
#include "Menu.h"
#include "Account.h"
#include "Test.h"
void menu(std::string name)
{
	std::string menu;
	std::cout << "�������� �������, ������� ������ ����������� ������ (h ��� ���������)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		std::cout << "test - �������� ������" << std::endl;
		std::cout << "stat - ���������� ������������" << std::endl;
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
			std::cout << "���������� ������������ " << name << std::endl;
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
	std::cout << "��� �� ������ �������? (h ��� ���������)" << std::endl;
	std::cin >> menu;

	if (menu == "h")
	{
		std::system("cls");
		std::cout << "login - ���� � �������" << std::endl;
		std::cout << "reg - �����������" << std::endl;
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
	std::cout << "��� �� ������ �������? (h ��� ���������)" << std::endl;
	std::cin >> menu;
	if (menu == "h")
	{
		system("cls");
		std::cout << "create - ������� ����" << std::endl;
		std::cout << "clearStat - ������� ���������� ��������� ������������" << std::endl;
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
			std::cout << "������� ��� ������������ ���������� ��������� �� ������ �������" << std::endl;
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
	std::cout << "������� �������" << std::endl;
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
			std::cout << "��� �����" << std::endl;
			std::cin >> ans;
			if (ans == a)
			{
				system("cls");
				std::cout << "���������� �����" << std::endl;
				system("pause");
				system("cls");
				count++;
				mark++;
			}
			else
			{
				system("cls");
				std::cout << "����� �� ����������" << std::endl;
				system("pause");
				system("cls");
				count++;
			}
		}
	}
	else
	{
		std::cout << "�� ���������� �������� ��������" << std::endl;
	}
	std::cout << "���� ������" << mark << "/" << count << std::endl;
	std::ofstream of(name + ".txt", std::ios::app);
	if (of.is_open())
	{
		of << mark << "/" << count;
	}
	of.close();
}
