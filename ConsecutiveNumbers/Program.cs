Console.Write("Enter the numbers : ");
string inputNumbers = Console.ReadLine();

string[] numbers = inputNumbers.Split("-");

if (CheckForConsecutiveNumbers(numbers))
{
    Console.WriteLine("Consecutive!");
}
else
{
    Console.WriteLine("Not Consecutive!");
}

bool CheckForConsecutiveNumbers(string[] numbers)
{
    bool consecutive = true;
    for (int index = 0; index < numbers.Length - 1; index++)
    {
        int number1 = Convert.ToInt32(numbers[index]);
        int number2 = Convert.ToInt32(numbers[index + 1]);
        int difference = number1 > number2 ? (number1 - number2) : (number2 - number1);
        if (difference != 1)
        {
            consecutive = false;
        }
    }

    return consecutive;
}

