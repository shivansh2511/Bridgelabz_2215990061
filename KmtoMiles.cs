using System;

class KmtoMiles
{
    static void Main()
    {
        // Define the distance in kilometers
        double kilometers = 10.8;

        // Conversion factor from kilometers to miles
        double conversionFactor = 1.6;

        // Calculate the distance in miles by multiplying the distance in kilometers by the conversion factor
        double miles = kilometers * conversionFactor;

        // Output the result to the console
        Console.WriteLine("The distance 10.8 km in miles is "+miles);
    }
}
