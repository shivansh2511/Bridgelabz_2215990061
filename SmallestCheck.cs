using System;

class SmallestCheck
{
    static void Main()
    {
        // Take user inputs for the three numbers
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Check if the first number is the smallest
        bool isSmallest = (number1 < number2) && (number1 < number3);

        // Output the result using string.Format
        Console.WriteLine(string.Format("Is the first number the smallest? {0}", isSmallest ? "Yes" : "No"));
    }
}
