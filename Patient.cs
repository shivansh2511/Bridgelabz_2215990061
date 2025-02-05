using System;

class Patient
{
    // Static variable shared across all patients
    private static string HospitalName = "City General Hospital";
    private static int totalPatients = 0; // Tracks total patients admitted

    // Readonly variable (cannot be changed after assignment)
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    // Constructor
    public Patient(int patientID, string name, int age, string ailment)
    {
        this.PatientID = patientID; // Resolving ambiguity using 'this'
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++; // Increment total patient count
    }

    // Method to display patient details
    public void DisplayPatientDetails()
    {
        // Checking if the object is an instance of Patient using 'is' operator
        if (this is Patient)
        {
            Console.WriteLine(string.Format("Hospital Name: {0}", HospitalName));
            Console.WriteLine(string.Format("Patient ID: {0}", this.PatientID));
            Console.WriteLine(string.Format("Name: {0}", this.Name));
            Console.WriteLine(string.Format("Age: {0}", this.Age));
            Console.WriteLine(string.Format("Ailment: {0}\n", this.Ailment));
        }
        else
        {
            Console.WriteLine("Invalid patient object.");
        }
    }

    // Static method to get the total number of admitted patients
    public static void GetTotalPatients()
    {
        Console.WriteLine(string.Format("Total Patients Admitted: {0}", totalPatients));
    }
}

// Main class to test the Patient class
class Program
{
    static void Main()
    {
        // Creating patient objects
        Patient patient1 = new Patient(101, "Alice Johnson", 35, "Fever");
        Patient patient2 = new Patient(102, "Bob Smith", 40, "Diabetes");

        // Displaying patient details
        Console.WriteLine("Patient 1 Details:");
        patient1.DisplayPatientDetails();

        Console.WriteLine("Patient 2 Details:");
        patient2.DisplayPatientDetails();

        // Displaying total number of patients
        Console.WriteLine();
        Patient.GetTotalPatients();
    }
}

