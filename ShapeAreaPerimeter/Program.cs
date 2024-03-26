using System;

Console.WriteLine("***Area and Perimeter Calculator***");
string selectedShape;
string[] shapes = { "square", "rectangle", "circle", "triangle" };
do
{
    Console.Write("\nPlease select the shape: \n\t* Square\n\t* Rectangle\n\t* Circle\n\t* Triangle\nEnter your option (type exit to close): ");
    selectedShape = Console.ReadLine();

    switch (selectedShape.ToLower())
    {
        case "square":
            Console.Write("\nEnter the Side of a Square: ");
            int side;
            int.TryParse(Console.ReadLine(), out side);
            Console.WriteLine($"\nArea : {Math.Pow(side, 2)} \nPerimeter: {(4 * side)}");
            break;
        case "rectangle":
            Console.Write("\nEnter the Width of a Rectangle: ");
            int width;
            int.TryParse(Console.ReadLine(), out width);
            Console.Write("\nEnter the Length of a Rectangle: ");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            Console.WriteLine($"\nArea : {length * width} \nPerimeter: {(length + width) * 2}");
            break;
        case "circle":
            Console.Write("\nEnter the Radius of a Circle: ");
            int radius;
            int.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine($"\nArea : {(3.14 * Math.Pow(radius, 2)):N2} \nPerimeter: {(2 * 3.14 * radius):N2}");
            break;
            break;
        case "triangle":
            Console.Write("\nEnter the Base of a Triangle: ");
            int baseValue;
            int.TryParse(Console.ReadLine(), out baseValue);
            Console.Write("\nEnter the Height of a Triangle: ");
            int height;
            int.TryParse(Console.ReadLine(), out height);
            Console.Write("\nEnter the Side of a Triangle: ");
            int triangleSides;
            int.TryParse(Console.ReadLine(), out triangleSides);
            Console.WriteLine($"\nArea : {(1 / 2) * baseValue * height} \nPerimeter: {(2 * triangleSides) + baseValue}");
            break;
    }
} while (selectedShape != "exit");
