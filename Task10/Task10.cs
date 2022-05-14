﻿//Write a programm which returns second digit of a three-digit number

int num;
string warning = "Wrong input. Enter a number between 100 and 999: ";

while (true)
{
    Console.Write("Enter a number between 100 and 999: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        if (number < 100 || number > 999)
        {
            Console.WriteLine(warning);
            continue;
        }
        num = number;
        break;
    }
    Console.WriteLine(warning);
}

int result = (num % 100) / 10;

Console.WriteLine($"The second digit of number {num} is {result}.");