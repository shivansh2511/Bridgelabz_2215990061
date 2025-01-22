using System;

class DistanceConversion
{
    static void Main()
    {
        // Prompt the user to enter the distance in feet
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double feetPerYard = 3;
        double yardsPerMile = 1760;

        // Calculate the distance in yards and miles
        double distanceInYards = distanceInFeet / feetPerYard;
        double distanceInMiles = distanceInYards / yardsPerMile;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The distance in feet is {0:F2}, which is {1:F2} yards and {2:F2} miles.", 
            distanceInFeet, distanceInYards, distanceInMiles));
    }
}
