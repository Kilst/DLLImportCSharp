// Lib.lib.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include<iostream>
#include<string>
#include<vector>
#include<algorithm>
#include<cmath>
using namespace std;

extern "C"
{
	__declspec(dllexport) int GetText(int choice)
	{
		/*switch (choice)
		{
		case 1:
			return 1 * 4;
			break;
		case 2:
			return 2 * 4;
			break;
		}*/
		return choice * 4;
	}

	__declspec(dllexport) char* Hello()
	{
		return "Hello World";
	}

	__declspec(dllexport) char* GuessNumber(int number)
	{
		if (number < 77)
			return "Less than!";
		else if (number > 77)
			return "Greater than!";
		else
			return "Correct!";
	}

	__declspec(dllexport) int TimesNumbers(int number1, int number2)
	{
		return number1 * number2;
	}
}