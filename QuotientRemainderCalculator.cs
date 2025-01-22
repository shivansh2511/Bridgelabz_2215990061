using System;

class QuotientRemainderCalculator
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient using division operator
        int quotient = number1 / number2;

        // Calculate the remainder using modulus operator
        int remainder = number1 % number2;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}.", 
            quotient, remainder, number1, number2));
    }
}
