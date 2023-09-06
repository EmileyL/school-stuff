using System;

namespace Unit1aLabs
{
	class VariablesAndOperators
	{
		static void Main(string[] args)
		{
		int number = 9; //this to bool is all just me making all sorts of variable types
		double numberAgain = 8.9;
		char begin = 'I';
		string adding = " know ";
		string pause = " is bigger than ";
		string ending = " and this is ";
		bool proof = true;
		Console.WriteLine(begin + adding + number + pause + numberAgain + ending + proof); //this makes a sentence
		Console.WriteLine(number += 5); //adds 5 to 9 and writes what it would be
		Console.WriteLine(numberAgain -= 6); //subtracts 6 from 8.9 and writes what it would be
		number++; //adds one to 9+5
        Console.WriteLine(number);
        Console.WriteLine(4/2); //would give 2 because yeah
        Console.WriteLine(5%2); //would give 1 because the max that 5 can be dived by 2 is 4 which leaves 1 left
         }
	}

}