using System;

class AthleteRounds
{
    static void Main()
    {
        // Take user input for the sides of the triangle
        Console.WriteLine("Enter the length of side 1 (in meters):");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2 (in meters):");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3 (in meters):");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Convert the distance to be run from kilometers to meters (5 km = 5000 meters)
        double totalDistance = 5000;

        // Calculate the number of rounds the athlete must complete
        double rounds = totalDistance / perimeter;

        // Output the result
        Console.WriteLine(string.Format("The total number of rounds the athlete will run is {0:F2} to complete 5 km.", rounds));
    }
}
