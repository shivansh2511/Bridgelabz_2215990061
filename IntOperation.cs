using System;

class IntOperation
{
    static void Main()
    {
        // Prompt the user to enter values for a, b, and c
        Console.WriteLine("Enter the value for a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value for b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value for c:");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations
        int result1 = a + b * c; // Multiplication (*) has higher precedence than addition (+)
        int result2 = a * b + c; // Multiplication (*) has higher precedence than addition (+)
        int result3 = c + a / b; // Division (/) has higher precedence than addition (+)
        int result4 = a % b + c; // Modulus (%) has higher precedence than addition (+)

        // Output the results using string.Format
        Console.WriteLine(string.Format("The results of Int Operations are {0}, {1}, {2}, and {3}.", 
            result1, result2, result3, result4));
    }
}
