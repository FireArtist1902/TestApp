#include "Test.h"
#include <fstream>
Test::Test()
{
}

void Test::addTest()
{
	std::cout << "������� �������" << std::endl;
	std::cin >> subject;
	std::cout << "������� ������� ����� (� ���� ��������� ������������ ����� � ��������� ��������)" << std::endl;
	std::cin >> question;
	std::cout << "������� �����" << std::endl;
	std::cin >> answer;
	std::ofstream f(subject + ".txt", std::ios::app);
	if (f.is_open())
	{
		f << question << '\n';
		f << answer << '\n';
	}
}
