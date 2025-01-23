using System;

class AbundantNumber
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize sum variable to 0
        int sum = 0;

        // Run a for loop from 1 to less than the number
        for (int i = 1; i < number; i++)
        {
            // Check if i is a divisor of the number
            if (number % i == 0)
            {
                sum += i;  // Add the divisor to sum
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            // If sum is greater, it's an Abundant Number
            Console.WriteLine(String.Format("{0} is an Abundant Number.", number));
        }
        else
        {
            // Otherwise, it's not an Abundant Number
            Console.WriteLine(String.Format("{0} is Not an Abundant Number.", number));
        }
    }
}
