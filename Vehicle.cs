using System;

class Vehicle
{
    // Static variable shared across all vehicles
    private static double RegistrationFee = 5000.00; // Default registration fee

    // Readonly variable (cannot be changed after assignment)
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    // Constructor
    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = registrationNumber; // Resolving ambiguity using 'this'
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    // Method to display vehicle details
    public void DisplayVehicleDetails()
    {
        // Checking if the object is an instance of Vehicle using 'is' operator
        if (this is Vehicle)
        {
            Console.WriteLine(string.Format("Registration Number: {0}", this.RegistrationNumber));
            Console.WriteLine(string.Format("Owner Name: {0}", this.OwnerName));
            Console.WriteLine(string.Format("Vehicle Type: {0}", this.VehicleType));
            Console.WriteLine(string.Format("Registration Fee: ${0:F2}\n", RegistrationFee));
        }
        else
        {
            Console.WriteLine("Invalid vehicle object.");
        }
    }

    // Static method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine(string.Format("Registration Fee updated to ${0:F2}", RegistrationFee));
    }
}

// Main class to test the Vehicle class
class Program
{
    static void Main()
    {
        // Creating vehicle objects
        Vehicle vehicle1 = new Vehicle("KA-01-AB-1234", "Alice Johnson", "Car");
        Vehicle vehicle2 = new Vehicle("MH-02-XY-5678", "Bob Smith", "Motorcycle");

        // Displaying vehicle details before fee update
        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();

        // Updating registration fee
        Console.WriteLine("Updating Registration Fee...\n");
        Vehicle.UpdateRegistrationFee(5500.00); // Updating fee to $5500

        // Displaying vehicle details after fee update
        Console.WriteLine("Vehicle 1 Details After Fee Update:");
        vehicle1.DisplayVehicleDetails();

        Console.WriteLine("Vehicle 2 Details After Fee Update:");
        vehicle2.DisplayVehicleDetails();
    }
}

