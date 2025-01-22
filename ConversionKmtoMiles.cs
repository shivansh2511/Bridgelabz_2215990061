using System;

class ConversionKmtoMiles
{
    static void Main()
    {
        // Prompt the user to enter the distance in kilometers
        Console.WriteLine("Enter the distance in kilometers:");

        // Read user input and convert it to a double
        double km = Convert.ToDouble(Console.ReadLine());

        // Conversion factor from kilometers to miles
        double conversionFactor = 1.6;

        // Calculate the distance in miles
        double miles = km / conversionFactor;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The total miles is {0:F2} mile(s) for the given {1:F2} km", miles, km));
    }
}
