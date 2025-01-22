using System;

class SideofSquare
{
    static void Main()
    {
        // Prompt the user to enter the perimeter of the square
        Console.WriteLine("Enter the perimeter of the square:");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The length of the side is {0:F2} whose perimeter is {1:F2}.", side, perimeter));
    }
}
