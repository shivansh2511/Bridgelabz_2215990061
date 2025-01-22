using System;

class DiscountedAmountUserInput
{
    static void Main()
    {
        // Prompt the user to enter the student fee
        Console.WriteLine("Enter the student fee in INR:");
        double fee = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the discount percentage
        Console.WriteLine("Enter the discount percentage:");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate the discount amount
        double discountAmount = (fee * discountPercent) / 100;

        // Calculate the final discounted fee
        double discountedFee = fee - discountAmount;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The discount amount is INR {0:F2} and the final discounted fee is INR {1:F2}", discountAmount, discountedFee));
    }
}
