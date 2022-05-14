//Write a programm that accepts a digit, indicating the day of the week as input
//and checks whether this day is a weekend

int num;
string warning = "Wrong input. Enter a number between 1 and 7: ";

string isWeekend(int number)
{
    var days = new Dictionary<int, string>()
    {
        {1, "No"},
        {2, "No"},
        {3, "No"},
        {4, "No"},
        {5, "No"},
        {6, "Yes"},
        {7, "Yes"},
    };
    return days[number];
}

while (true)
{
    Console.Write("Enter a number between 1 and 7: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number)) //Checking if input is a number within acceptable limits 
    {
        if (number < 1 || number > 7)
        {
            Console.WriteLine(warning);
            continue;
        }
        num = number;
        break;
    }
    Console.WriteLine(warning);
}

Console.WriteLine(isWeekend(num));