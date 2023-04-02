#include "Test.h"
#include <fstream>
Test::Test()
{
}

void Test::addTest()
{
	std::cout << "¬ведите предмет" << std::endl;
	std::cin >> subject;
	std::cout << "¬ведите задание теста (в этой программе используютс€ тесты с открытыми ответами)" << std::endl;
	std::cin >> question;
	std::cout << "¬ведите ответ" << std::endl;
	std::cin >> answer;
	std::ofstream f(subject + ".txt", std::ios::app);
	if (f.is_open())
	{
		f << question << '\n';
		f << answer << '\n';
	}
}
