using System;

class DayOfWeek
{
    static void Main()
    {
        // Prompt user for month, day, and year
        Console.Write("Enter the month (1-12): ");
        int m = int.Parse(Console.ReadLine());  // month

        Console.Write("Enter the day: ");
        int d = int.Parse(Console.ReadLine());  // day

        Console.Write("Enter the year: ");
        int y = int.Parse(Console.ReadLine());  // year

        // Formula to calculate the day of the week
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the day of the week as per the formula
        Console.WriteLine("The day of the week is: " + d0);
    }
}
