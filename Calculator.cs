using System;

class Calculator

{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        // Output the results using string.Format
        Console.WriteLine(string.Format("The addition, subtraction, multiplication, and division of the numbers {0:F2} and {1:F2} are {2:F2}, {3:F2}, {4:F2}, and {5:F2} respectively.",
            number1, number2, addition, subtraction, multiplication, division));
    }
}
