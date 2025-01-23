using System;

class HarshadNumber
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize sum variable to 0
        int sum = 0;
        int originalNumber = number;

        // Use a while loop to calculate the sum of digits
        while (number != 0)
        {
            sum += number % 10;  // Add the last digit of the number to sum
            number /= 10;  // Remove the last digit from the number
        }

        // Check if the number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            // If divisible, it's a Harshad number
            Console.WriteLine(String.Format("{0} is a Harshad Number.", originalNumber));
        }
        else
        {
            // Otherwise, it's not a Harshad number
            Console.WriteLine(String.Format("{0} is Not a Harshad Number.", originalNumber));
        }
    }
}
