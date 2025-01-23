using System;

class GreatestFactor
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Initialize the greatestFactor variable
        int greatestFactor = 1;

        // Loop from number-1 to 1 to find the greatest factor
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0) // Check if i is a divisor of number
            {
                greatestFactor = i; // Assign i to greatestFactor
                break; // Exit the loop once the greatest factor is found
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of {0} besides itself is: {1}", number, greatestFactor);
    }
}
