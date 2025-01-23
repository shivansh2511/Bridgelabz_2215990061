using System;

class SumUntilZero
{
    static void Main()
    {
        // Initialize total sum to 0.0
        double total = 0.0;
        double userInput;

        // Inform the user
        Console.WriteLine("Enter numbers to sum (enter 0 to stop):");

        // Start the while loop to keep summing until user enters 0
        while (true)
        {
            // Take user input
            userInput = Convert.ToDouble(Console.ReadLine());

            // Check if the user entered 0, if so break the loop
            if (userInput == 0)
                break;

            // Add the user input to the total sum
            total += userInput;
        }

        // Output the total sum using string.Format
        Console.WriteLine(string.Format("The total sum of the entered numbers is: {0}", total));
    }
}
