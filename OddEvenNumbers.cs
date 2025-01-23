using System;

class OddEvenNumbers
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a natural number (positive integer)
        if (num <= 0)
        {
            Console.WriteLine("The number entered is not a valid natural number.");
        }
        else
        {
            // Iterate from 1 to the number entered
            for (int i = 1; i <= num; i++)
            {
                // Check if the number is even or odd
                if (i % 2 == 0)
                {
                    Console.WriteLine(string.Format("{0} is an even number.", i));
                }
                else
                {
                    Console.WriteLine(string.Format("{0} is an odd number.", i));
                }
            }
        }
    }
}
