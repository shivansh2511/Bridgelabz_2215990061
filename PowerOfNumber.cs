using System;

class PowerOfNumber
{
    static void Main()
    {
        // Take input for number and power
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());
        
        // Initialize result as 1
        int result = 1;

        // Loop to calculate the power of the number
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result by the base number in each iteration
        }

        // Output the result
        Console.WriteLine("The result of {0} raised to the power of {1} is: {2}", number, power, result);
    }
}
