using System;

class ChocolateDistribution
{
    static void Main()
    {
        // Take user input for the number of chocolates and number of children
        Console.WriteLine("Enter the total number of chocolates:");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate how many chocolates each child gets
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;

        // Calculate the number of remaining chocolates
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}.", 
            chocolatesPerChild, remainingChocolates));
    }
}
