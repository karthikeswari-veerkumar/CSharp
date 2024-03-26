using System;

int number;
Console.Write("Enter the input number : ");
int.TryParse(Console.ReadLine(), out number);
Console.Write("Enter the Start Bit : ");
int.TryParse(Console.ReadLine(), out int startBit);
Console.Write("Enter the Stop Bit : ");
int.TryParse(Console.ReadLine(), out int stopBit);

string binary = Convert.ToString(number, 2);
string reversedBinary = GetReversedBinary(binary);
string extractedBinary = GetExtractedBinary(reversedBinary, startBit, stopBit);

Console.WriteLine($"\nExtracted Binary Value : {extractedBinary}");
Console.WriteLine($"Decimal Value : {Convert.ToInt32(extractedBinary, 2)}");

string GetReversedBinary(string binary)
{
    char[] binaryArray = binary.ToCharArray();
    Array.Reverse(binaryArray);
    return new string(binaryArray);
}

string GetExtractedBinary(string binary, int startBit, int stopBit)
{
    string extractedBinary = binary.Substring(startBit, stopBit - startBit + 1);
    char[] extractedBinArray = extractedBinary.ToCharArray();
    Array.Reverse(extractedBinArray);
    return new string(extractedBinArray);
}
