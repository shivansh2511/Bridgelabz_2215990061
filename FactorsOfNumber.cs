using System;

class FactorsOfNumber
{
    static void Main()
    {
        // Get input for the number
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The factors of {0} are:", number);

        // Loop to find factors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if i is a factor
            {
                Console.WriteLine(i);
            }
        }
    }
}
