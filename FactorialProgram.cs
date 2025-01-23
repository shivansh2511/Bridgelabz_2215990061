using System;

class FactorialProgram
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

            // Use a while loop to calculate the factorial
            while (num > 1)
            {
                factorial *= num;
                num--;  // Decrease num by 1 in each iteration
            }

            // Print the result
            Console.WriteLine(string.Format("The factorial is: {0}", factorial));
        }
    }
}
