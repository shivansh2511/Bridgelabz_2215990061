using System;

class SwapNumbers
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the two numbers using a temporary variable
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Output the swapped result using string.Format
        Console.WriteLine(string.Format("The swapped numbers are {0} and {1}.", number1, number2));
    }
}
