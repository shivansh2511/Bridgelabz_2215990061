using System;

class MultiplesOfNumber
{
    static void Main()
    {
        // Get input for the number
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The multiples of {0} below 100 are:", number);

        // Loop backward from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)  // Check if i is a multiple of the number
            {
                Console.WriteLine(i);  // Print the multiple
            }
        }
    }
}
