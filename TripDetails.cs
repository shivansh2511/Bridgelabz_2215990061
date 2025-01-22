using System;

class TripDetails
{
    static void Main()
    {
        // Take user input for name, cities, and distances
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the starting city:");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enter the via city:");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enter the final destination city:");
        string toCity = Console.ReadLine();

        Console.WriteLine("Enter the distance from the starting city to the via city (in miles):");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the distance from the via city to the final destination (in miles):");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the total time taken for the journey (in hours):");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculate the total distance
        double totalDistance = fromToVia + viaToFinalCity;

        // Calculate the average speed
        double averageSpeed = totalDistance / timeTaken;

        // Output the results
        Console.WriteLine(string.Format("The results of the trip are: Name: {0}, Total Distance: {1:F2} miles, Average Speed: {2:F2} mph.", 
            name, totalDistance, averageSpeed));
    }
}
