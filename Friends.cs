using System;

class Friends
{
    static void Main()
    {
        // Taking input for ages and heights
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Amar's height in cm: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's height in cm: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's height in cm: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        // Finding the youngest friend (smallest age)
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));

        if (youngestAge == amarAge)
        {
            Console.WriteLine("The youngest friend is Amar.");
        }
        else if (youngestAge == akbarAge)
        {
            Console.WriteLine("The youngest friend is Akbar.");
        }
        else
        {
            Console.WriteLine("The youngest friend is Anthony.");
        }

        // Finding the tallest friend (largest height)
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        if (tallestHeight == amarHeight)
        {
            Console.WriteLine("The tallest friend is Amar.");
        }
        else if (tallestHeight == akbarHeight)
        {
            Console.WriteLine("The tallest friend is Akbar.");
        }
        else
        {
            Console.WriteLine("The tallest friend is Anthony.");
        }
    }
}
