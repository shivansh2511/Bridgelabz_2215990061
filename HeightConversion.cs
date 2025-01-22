using System;

class HeightConversion
{
    static void Main()
    {
        // Prompt the user to enter height in centimeters
        Console.WriteLine("Enter your height in centimeters:");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double cmPerInch = 2.54;
        int inchesPerFoot = 12;

        // Convert height from centimeters to inches
        double totalInches = heightCm / cmPerInch;

        // Calculate the height in feet and remaining inches
        int feet = (int)(totalInches / inchesPerFoot);
        double inches = totalInches % inchesPerFoot;

        // Output the result using string.Format
        Console.WriteLine(string.Format("Your Height in cm is {0:F2} while in feet is {1} and inches is {2:F2}", heightCm, feet, inches));
    }
}
