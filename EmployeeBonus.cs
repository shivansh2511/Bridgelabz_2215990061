using System;

class EmployeeBonus
{
    static void Main()
    {
        // Get user input for salary and years of service
        Console.Write("Enter the salary of the employee: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Check if years of service is greater than 5
        if (yearsOfService > 5)
        {
            // Calculate bonus as 5% of the salary
            double bonus = salary * 0.05;
            Console.WriteLine("The bonus amount is: INR " + bonus);
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
