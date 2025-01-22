using System;

class TotalPrice
{
    static void Main()
    {
        // Prompt the user to enter the unit price
        Console.WriteLine("Enter the unit price of the item (INR):");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the quantity
        Console.WriteLine("Enter the quantity to be bought:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total purchase price
        double totalPrice = unitPrice * quantity;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The total purchase price is INR {0:F2} if the quantity is {1} and the unit price is INR {2:F2}.", 
            totalPrice, quantity, unitPrice));
    }
}
