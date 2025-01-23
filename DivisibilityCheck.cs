using System;

class DivisibilityCheck
{
    static void Main()
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check divisibility by 5
        bool isDivisible = (number % 5 == 0);

        // Output the result using string.Format
        Console.WriteLine(string.Format("Is the number {0} divisible by 5? {1}", number, isDivisible ? "Yes" : "No"));
    }
}
