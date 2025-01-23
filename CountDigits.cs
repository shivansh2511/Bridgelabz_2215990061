using System;

class CountDigits
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize count variable to 0
        int count = 0;

        // Use a loop to count the digits
        while (number != 0)
        {
            number /= 10; // Remove the last digit from the number
            count++; // Increase the count by 1
        }

        // Display the result using String.Format
        Console.WriteLine(String.Format("The number has {0} digits.", count));
    }
}
