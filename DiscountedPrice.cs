using System;

class DiscountedPrice
{
    static void Main()
    {
        // Define the course fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate the discount amount
        double discountAmount = (fee * discountPercent) / 100;

        // Calculate the final discounted fee
        double discountedFee = fee - discountAmount;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The discount amount is INR {0:F2} and the final discounted fee is INR {1:F2}", discountAmount, discountedFee));
    }
}
