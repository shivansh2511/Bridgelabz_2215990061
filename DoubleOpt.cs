using System;

class DoubleOpt
{
    static void Main()
    {
        // Prompt the user to enter values for a, b, and c
        Console.WriteLine("Enter the value for a (double):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value for b (double):");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value for c (double):");
        double c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations
        double result1 = a + b * c; // Multiplication (*) has higher precedence than addition (+)
        double result2 = a * b + c; // Multiplication (*) has higher precedence than addition (+)
        double result3 = c + a / b; // Division (/) has higher precedence than addition (+)
        double result4 = a % b + c; // Modulus (%) has higher precedence than addition (+)

        // Output the results using string.Format
        Console.WriteLine(string.Format("The results of Double Operations are {0:F2}, {1:F2}, {2:F2}, and {3:F2}.", 
            result1, result2, result3, result4));
    }
}
