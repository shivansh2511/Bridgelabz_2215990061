using System;

class SumUntilZeroOrNegative
{
    static void Main()
    {
        double total = 0.0; // Variable to store the cumulative sum of the numbers.
        double userInput; // Variable to store each number input by the user.

        Console.WriteLine("Enter numbers to sum (enter 0 or a negative number to stop):");

        // Infinite loop to continuously ask the user for input.
        while (true)
        {
            userInput = Convert.ToDouble(Console.ReadLine()); // Take input from the user and convert it to a double.

            // Check if the input is 0 or a negative number to break the loop.
            if (userInput <= 0)
                break; // Exit the loop if the number is 0 or negative.

            total += userInput; // Add the user's input to the total sum.
        }

        // Output the result, displaying the total sum.
        Console.WriteLine(string.Format("The total sum of the entered numbers is: {0}", total));
    }
}
