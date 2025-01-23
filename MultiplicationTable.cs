using System;

class MultiplicationTable
{
    static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number to generate its multiplication table (for multipliers 6 to 9): ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Loop through multipliers from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            // Print the multiplication table in the desired format
            Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
        }
    }
}
