using System;

class ProfitandLoss
{
    static void Main()
    {
        // Define the cost price and selling price
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculate the profit
        double profit = sellingPrice - costPrice;

        // Calculate the profit percentage
        double profitPercentage = (profit / costPrice) * 100;

        // Output the result using a single print statement with multiline text "$ cmd was giving error as $ is an unexpected symbol so i am using "string.Format""
        Console.WriteLine(string.Format("The Cost Price is INR {0} and Selling Price is INR {1}\n" +
                          "The Profit is INR {2} and the Profit Percentage is {3:F2}%",costPrice,sellingPrice,profit,profitPercentage));
    }
}