using System;

class AreaofTriangle
{
    static void Main()
    {
        // Prompt the user to enter the base in inches
        Console.WriteLine("Enter the base of the triangle in inches:");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height in inches
        Console.WriteLine("Enter the height of the triangle in inches:");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        // Calculate the area in square inches
        double areaInSquareInches = 0.5 * baseInches * heightInches;

        // Conversion factor from square inches to square centimeters
        double conversionFactor = 6.4516;

        // Convert the area to square centimeters
        double areaInSquareCentimeters = areaInSquareInches * conversionFactor;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The area of the triangle is {0:F2} square inches and {1:F2} square centimeters.", 
            areaInSquareInches, areaInSquareCentimeters));
    }
}
