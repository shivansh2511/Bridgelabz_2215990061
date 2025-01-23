using System;

class RocketLaunchCountdown
{
    static void Main()
    {
        // Take user input for the starting countdown value
        Console.WriteLine("Enter the countdown starting number:");
        int counter = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nStarting the countdown:");
        
        // While loop to count down to 1
        while (counter >= 1)
        {
            // Print the current countdown value
            Console.WriteLine(counter);
            
            // Decrement the counter
            counter--;
        }
        
        // Print "Liftoff!" after the countdown reaches 0
        Console.WriteLine("Liftoff!");
    }
}
