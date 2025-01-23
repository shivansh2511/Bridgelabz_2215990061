using System;

class SpringSeason
{
    static void Main()
    {
        // Take user input for month and day
        Console.WriteLine("Enter the month (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the day (1-31):");
        int day = Convert.ToInt32(Console.ReadLine());

        // Check if the date falls in the spring season
        bool isSpring = (month == 3 && day >= 20 && day <= 31) || // March 20 to March 31
                        (month == 4 && day >= 1 && day <= 30) ||  // April (entire month)
                        (month == 5 && day >= 1 && day <= 31) ||  // May (entire month)
                        (month == 6 && day >= 1 && day <= 20);    // June 1 to June 20

        // Output result
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
