Console.Write("Enter the no of rows: ");
int rows;
int.TryParse(Console.ReadLine(), out rows);

if (rows > 10 || rows >= 0)
{
    Console.WriteLine("Invalid Input!");
}
else
{
    for (int row = 0; row < (rows); row++)
    {
        //add spaces
        int totalColumns = (rows) + (rows - 1);
        for (int column = 0; column < ((totalColumns / 2) - row); column++)
        {
            Console.Write("\t");
        }

        //print *
        for (int count = 0; count <= row; count++)
        {
            Console.Write("*\t\t");
        }
        Console.Write("\n\n");
    }

}

