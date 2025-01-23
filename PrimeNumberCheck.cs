using System;

class PrimeNumberCheck
{
    static void Main()
    {
        // Get user input for the number to check if it's prime
        Console.Write("Enter a number to check if it's prime: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is less than 2
        if (number <= 1)
        {
            Console.WriteLine("{0} is not a prime number.", number);
            return;  // If the number is less than or equal to 1, it's not prime
        }

        // Boolean flag to check if the number is prime
        bool isPrime = true;

        // Loop through numbers from 2 to sqrt(number) to check for divisibility
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            // If the number is divisible by i, it's not prime
            if (number % i == 0)
            {
                isPrime = false;
                break;  // Exit the loop as the number is not prime
            }
        }

        // Output the result
        if (isPrime)
        {
            Console.WriteLine("{0} is a prime number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", number);
        }
    }
}
