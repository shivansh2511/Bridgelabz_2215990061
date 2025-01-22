using System;

class TemperatureConversion
{
    static void Main()
    {
        // Prompt the user to enter the temperature in Celsius
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The {0} Celsius is {1:F2} Fahrenheit.", celsius, fahrenheit));
    }
}
