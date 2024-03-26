Console.WriteLine("Case Conversion");
string inputMessage;
do
{
    Console.Write("\nEnter the String (type stop to exit) : ");
    inputMessage = Console.ReadLine();
    if (inputMessage != "stop")
        Console.WriteLine($"Case converted string is {inputMessage.ToUpper()}");
} while (inputMessage != "stop");

