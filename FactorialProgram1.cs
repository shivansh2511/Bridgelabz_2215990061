using System;

class FactorialProgram1
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a positive integer
        if (num < 0)
        {
            Console.WriteLine("The number entered is not a positive integer.");
        }
        else
        {
            // Initialize the factorial variable
            int factorial = 1;

            // Use a for loop to calculate the factorial
            for (int i = 1; i <= num; i++)
            {
                factorial *= i; // Multiply the current factorial value by i
            }

            // Print the result
            Console.WriteLine(string.Format("The factorial is: {0}", factorial));
        }
    }
}
