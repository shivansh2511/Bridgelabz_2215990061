using System;

class BankAccount
{
    // Static variable shared across all accounts
    private static string bankName = "Global Bank";
    private static int totalAccounts = 0; // Tracks the total number of accounts

    // Readonly variable (cannot be changed after assignment)
    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
    {
        this.AccountNumber = accountNumber; // Resolving ambiguity using 'this'
        this.AccountHolderName = accountHolderName;
        this.Balance = initialBalance;
        totalAccounts++; // Increment total account count
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        // Checking if the object is an instance of BankAccount using 'is' operator
        if (this is BankAccount)
        {
            Console.WriteLine(string.Format("Bank Name: {0}", bankName));
            Console.WriteLine(string.Format("Account Number: {0}", this.AccountNumber));
            Console.WriteLine(string.Format("Account Holder: {0}", this.AccountHolderName));
            Console.WriteLine(string.Format("Balance: ${0:F2}", this.Balance));
        }
        else
        {
            Console.WriteLine("Invalid account object.");
        }
    }

    // Static method to get total number of accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine(string.Format("Total Bank Accounts: {0}", totalAccounts));
    }
}

// Main class to test the BankAccount class
class Program
{
    static void Main()
    {
        // Creating bank accounts
        BankAccount acc1 = new BankAccount(101, "John Doe", 5000.75);
        BankAccount acc2 = new BankAccount(102, "Jane Smith", 3000.50);

        // Displaying account details
        Console.WriteLine("Account 1 Details:");
        acc1.DisplayAccountDetails();

        Console.WriteLine("\nAccount 2 Details:");
        acc2.DisplayAccountDetails();

        // Displaying total number of accounts
        Console.WriteLine();
        BankAccount.GetTotalAccounts();
    }
}

