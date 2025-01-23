using System;

class Calculator2
{
    static void Main()
    {
        // Declare variables
        double first, second;
        string op;

        // Get input for the numbers and operator
        Console.Write("Enter the first number: ");
        first = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        second = double.Parse(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        op = Console.ReadLine();

        // Perform the operation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + string.Format("{0} + {1} = {2}", first, second, first + second));
                break;
            case "-":
                Console.WriteLine("Result: " + string.Format("{0} - {1} = {2}", first, second, first - second));
                break;
            case "*":
                Console.WriteLine("Result: " + string.Format("{0} * {1} = {2}", first, second, first * second));
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + string.Format("{0} / {1} = {2}", first, second, first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
    }
}
