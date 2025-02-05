using System;

class Product
{
    // Static variable shared across all products
    private static double Discount = 5.0; // Default discount in percentage

    // Readonly variable (cannot be changed after assignment)
    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor
    public Product(int productID, string productName, double price, int quantity)
    {
        this.ProductID = productID; // Resolving ambiguity using 'this'
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Method to display product details
    public void DisplayProductDetails()
    {
        // Checking if the object is an instance of Product using 'is' operator
        if (this is Product)
        {
            Console.WriteLine(string.Format("Product ID: {0}", this.ProductID));
            Console.WriteLine(string.Format("Product Name: {0}", this.ProductName));
            Console.WriteLine(string.Format("Price: ${0:F2}", this.Price));
            Console.WriteLine(string.Format("Quantity: {0}", this.Quantity));
            Console.WriteLine(string.Format("Discount: {0}%\n", Discount));
        }
        else
        {
            Console.WriteLine("Invalid product object.");
        }
    }

    // Static method to update the discount percentage
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine(string.Format("Discount updated to {0}%", Discount));
    }
}

// Main class to test the Product class
class Program
{
    static void Main()
    {
        // Creating product objects
        Product prod1 = new Product(101, "Laptop", 1200.99, 2);
        Product prod2 = new Product(102, "Smartphone", 699.49, 3);

        // Displaying product details before discount update
        Console.WriteLine("Product 1 Details:");
        prod1.DisplayProductDetails();

        Console.WriteLine("Product 2 Details:");
        prod2.DisplayProductDetails();

        // Updating discount percentage
        Console.WriteLine("Updating discount...\n");
        Product.UpdateDiscount(10.0); // Updating discount to 10%

        // Displaying product details after discount update
        Console.WriteLine("Product 1 Details After Discount Update:");
        prod1.DisplayProductDetails();

        Console.WriteLine("Product 2 Details After Discount Update:");
        prod2.DisplayProductDetails();
    }
}

