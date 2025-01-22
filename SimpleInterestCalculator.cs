using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Take user input for Principal, Rate, and Time
        Console.WriteLine("Enter the Principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate the Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The Simple Interest is {0:F2} for Principal {1}, Rate of Interest {2}, and Time {3}.", 
            simpleInterest, principal, rate, time));
    }
}
