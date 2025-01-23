using System;

class ArmstrongNumber
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number to check if it's an Armstrong number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize variables
        int sum = 0;
        int originalNumber = number;

        // While loop to check each digit
        while (number != 0)
        {
            int remainder = number % 10; // Get the last digit of the number
            sum += remainder * remainder * remainder; // Add the cube of the digit to the sum
            number /= 10; // Remove the last digit from the number
        }

        // Check if the sum of cubes is equal to the original number
        if (sum == originalNumber)
        {
            // Using String.Format for output
            Console.WriteLine(String.Format("{0} is an Armstrong number.", originalNumber));
        }
        else
        {
            // Using String.Format for output
            Console.WriteLine(String.Format("{0} is not an Armstrong number.", originalNumber));
        }
    }
}
