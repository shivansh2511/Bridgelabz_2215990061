using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a natural number (positive integer)
        if (n <= 0)
        {
            Console.WriteLine("The number entered is not a natural number.");
        }
        else
        {
            // Calculate the sum using the formula
            int sumUsingFormula = (n * (n + 1)) / 2;

            // Calculate the sum using a while loop
            int sumUsingWhile = 0;
            int i = 1;
            while (i <= n)
            {
                sumUsingWhile += i;
                i++;
            }

            // Compare the results and display them
            Console.WriteLine(string.Format("Sum using formula: {0}", sumUsingFormula));
            Console.WriteLine(string.Format("Sum using while loop: {0}", sumUsingWhile));

            // Check if the results match
            if (sumUsingFormula == sumUsingWhile)
            {
                Console.WriteLine("The results match! Both computations are correct.");
            }
            else
            {
                Console.WriteLine("The results do not match.");
            }
        }
    }
}
