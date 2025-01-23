using System;

class FizzBuzz
{
    static void Main()
    {
        // Get user input for the positive integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Loop through numbers from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Check if the number is divisible by 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Check if the number is divisible by 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // Print the number itself if it's not divisible by 3 or 5
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
