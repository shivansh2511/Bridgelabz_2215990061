using System;

class RocketLaunchCountdown1
{
    static void Main()
    {
        // Take user input for the starting countdown value
        Console.WriteLine("Enter the countdown starting number:");
        int counter = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nStarting the countdown:");

        // Use a for loop to count down to 1
        for (int i = counter; i >= 1; i--)
        {
            // Print the current countdown value
            Console.WriteLine(i);
        }

        // Print "Liftoff!" after the countdown
        Console.WriteLine("Liftoff!");
    }
}
