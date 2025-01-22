using System;

class WeightConversion
{
    static void Main()
    {
        // Take user input for weight in pounds
        Console.WriteLine("Enter the weight in pounds:");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms (1 pound = 2.2 kg)
        double weightInKg = weightInPounds * 2.2;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The weight of the person in pounds is {0} and in kg is {1:F2}.", weightInPounds, weightInKg));
    }
}
