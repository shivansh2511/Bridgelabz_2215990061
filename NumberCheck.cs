using System;

class NumberCheck
{
    static void Main()
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (number > 0)
        {
            // Output for positive numbers
            Console.WriteLine(string.Format("The number {0} is positive.", number));
        }
        else if (number < 0)
        {
            // Output for negative numbers
            Console.WriteLine(string.Format("The number {0} is negative.", number));
        }
        else
        {
            // Output for zero
            Console.WriteLine("The number is zero.");
        }
    }
}
