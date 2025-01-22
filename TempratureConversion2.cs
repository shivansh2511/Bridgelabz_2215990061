using System;

class TemperatureConversion2
{
    static void Main()
    {
        // Prompt the user to enter the temperature in Fahrenheit
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The {0} Fahrenheit is {1:F2} Celsius.", fahrenheit, celsius));
    }
}
