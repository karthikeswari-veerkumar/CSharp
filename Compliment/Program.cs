using System;

Console.WriteLine("Enter a number to find 1's and 2's Compliment : ");
int inputNumber;
string inputString = Console.ReadLine();

int.TryParse(inputString, out inputNumber);

string binary = Convert.ToString(inputNumber, 2);

Console.WriteLine($"1's Complement of {inputString} is {find1sComplement(binary)}\n2's Complement of {inputString} is {find2sComplement(binary)}");

int find1sComplement(string binary)
{
    char[] binaryArray = binary.ToCharArray();
    string complementedBinary;

    for (int index = 0; index < binaryArray.Length; index++)
    {
        binaryArray[index] = binaryArray[index] == '0' ? '1' : '0';
    }

    complementedBinary = string.Join("", binaryArray);

    return Convert.ToInt32(complementedBinary, 2);
}

int find2sComplement(string binary)
{
    return find1sComplement(binary) + 1;
}