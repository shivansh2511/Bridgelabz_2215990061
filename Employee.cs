using System;

class Employee
{
    // Static variable shared across all employees
    private static string CompanyName = "Tech Solutions Pvt. Ltd.";
    private static int totalEmployees = 0; // Tracks total employees

    // Readonly variable (cannot be changed after assignment)
    public readonly int Id;
    public string Name;
    public string Designation;

    // Constructor
    public Employee(int id, string name, string designation)
    {
        this.Id = id; // Resolving ambiguity using 'this'
        this.Name = name;
        this.Designation = designation;
        totalEmployees++; // Increment total employees count
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        // Checking if the object is an instance of Employee using 'is' operator
        if (this is Employee)
        {
            Console.WriteLine(string.Format("Company Name: {0}", CompanyName));
            Console.WriteLine(string.Format("Employee ID: {0}", this.Id));
            Console.WriteLine(string.Format("Name: {0}", this.Name));
            Console.WriteLine(string.Format("Designation: {0}", this.Designation));
        }
        else
        {
            Console.WriteLine("Invalid employee object.");
        }
    }

    // Static method to display total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine(string.Format("Total Employees: {0}", totalEmployees));
    }
}

// Main class to test the Employee class
class Program
{
    static void Main()
    {
        // Creating employee objects
        Employee emp1 = new Employee(101, "Alice Johnson", "Software Engineer");
        Employee emp2 = new Employee(102, "Bob Smith", "Project Manager");

        // Displaying employee details
        Console.WriteLine("Employee 1 Details:");
        emp1.DisplayEmployeeDetails();

        Console.WriteLine("\nEmployee 2 Details:");
        emp2.DisplayEmployeeDetails();

        // Displaying total number of employees
        Console.WriteLine();
        Employee.DisplayTotalEmployees();
    }
}

