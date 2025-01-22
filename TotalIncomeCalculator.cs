using System;

class TotalIncomeCalculator
{
    static void Main()
    {
        // Prompt the user to enter the salary
        Console.WriteLine("Enter the salary (INR):");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the bonus
        Console.WriteLine("Enter the bonus (INR):");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate the total income
        double totalIncome = salary + bonus;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The salary is INR {0} and bonus is INR {1}. Hence, Total Income is INR {2}.", 
            salary, bonus, totalIncome));
    }
}
