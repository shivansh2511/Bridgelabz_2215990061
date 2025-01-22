using System;

class VolumeofEarth
{
    static void Main()
    {
        // Define the radius of the Earth in kilometers
        double radiusKm = 6378;

        // Conversion factor from cubic kilometers to cubic miles (1 km^3 = 0.621371^3 miles^3)
        double conversionFactor = Math.Pow(0.621371, 3);

        // Calculate the volume of the Earth in cubic kilometers
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Convert the volume to cubic miles
        double volumeMiles3 = volumeKm3 * conversionFactor;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The volume of Earth in cubic kilometers is {0:F2} and in cubic miles is {1:F2}", volumeKm3, volumeMiles3));
    }
}
