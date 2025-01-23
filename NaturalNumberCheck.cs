using System;

class NaturalNumberCheck
{
    static void Main()
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a natural number
        if (number >= 0)
        {
            // Calculate the sum of n natural numbers
            int sum = number * (number + 1) / 2;

            // Output the result using string.Format
            Console.WriteLine(string.Format("The sum of {0} natural numbers is {1}", number, sum));
        }
        else
        {
            // Output for non-natural numbers
            Console.WriteLine(string.Format("The number {0} is not a natural number", number));
        }
    }
}
