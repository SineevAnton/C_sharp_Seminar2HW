//Write a programm which returns third digit of n input number
//or says than number length is less than three

//using Math;

int num;

int ReturnThirdDigit_fromInt(int number)
{
    int numLenght = (Convert.ToString(number)).Length;
    int delimeter1 = (int)Math.Pow(10, (numLenght - 2));
    // delimeter1 will be used to 'delete' first two digits of number
    int delimeter2 = (int)Math.Pow(10, (numLenght - 3));
    // delimeter2 will be used to get first digit of a number the first two digits of which have been deleted
    return (number % delimeter1) / delimeter2;
}

int ReturnThirdDigit_fromString(int number)
{
    int result = (int)char.GetNumericValue(Convert.ToString(number)[2]);
    return result;
}

while (true)
{
    Console.Write("Enter a random number: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number)) //Checking if input is a number 
    {
        if (number < 0 )
        {
            number = number * (-1);
        }
        num = number;
        break;
    }
    Console.WriteLine("Wrong input. Enter a random number: ");
}

if (Convert.ToString(num).Length < 3)
{
    Console.WriteLine("There is no third digit.");
}
else
{
    Console.WriteLine(ReturnThirdDigit_fromInt(num)  + " (from int number)");
    Console.WriteLine(ReturnThirdDigit_fromString(num) + " (using array)");
}
