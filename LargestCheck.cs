using System;

class LargestCheck
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

        // Check which number is the largest
        bool isFirstLargest = (number1 > number2) && (number1 > number3);
        bool isSecondLargest = (number2 > number1) && (number2 > number3);
        bool isThirdLargest = (number3 > number1) && (number3 > number2);

        // Output the results using string.Format
        Console.WriteLine(string.Format("Is the first number the largest? {0}", isFirstLargest ? "Yes" : "No"));
        Console.WriteLine(string.Format("Is the second number the largest? {0}", isSecondLargest ? "Yes" : "No"));
        Console.WriteLine(string.Format("Is the third number the largest? {0}", isThirdLargest ? "Yes" : "No"));
    }
}
