using System;

class Student
{
    // Static variable shared across all students
    private static string UniversityName = "Global University";
    private static int totalStudents = 0; // Tracks total number of students

    // Readonly variable (cannot be changed after assignment)
    public readonly int RollNumber;
    public string Name;
    public char Grade;

    // Constructor
    public Student(int rollNumber, string name, char grade)
    {
        this.RollNumber = rollNumber; // Resolving ambiguity using 'this'
        this.Name = name;
        this.Grade = grade;
        totalStudents++; // Increment total student count
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        // Checking if the object is an instance of Student using 'is' operator
        if (this is Student)
        {
            Console.WriteLine(string.Format("University Name: {0}", UniversityName));
            Console.WriteLine(string.Format("Roll Number: {0}", this.RollNumber));
            Console.WriteLine(string.Format("Name: {0}", this.Name));
            Console.WriteLine(string.Format("Grade: {0}", this.Grade));
        }
        else
        {
            Console.WriteLine("Invalid student object.");
        }
    }

    // Method to update the student's grade
    public void UpdateGrade(char newGrade)
    {
        if (this is Student)
        {
            this.Grade = newGrade;
            Console.WriteLine(string.Format("{0}'s grade has been updated to {1}.", this.Name, this.Grade));
        }
        else
        {
            Console.WriteLine("Invalid student object.");
        }
    }

    // Static method to display total number of students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine(string.Format("Total Students Enrolled: {0}", totalStudents));
    }
}

// Main class to test the Student class
class Program
{
    static void Main()
    {
        // Creating student objects
        Student student1 = new Student(101, "Alice Johnson", 'A');
        Student student2 = new Student(102, "Bob Smith", 'B');

        // Displaying student details
        Console.WriteLine("Student 1 Details:");
        student1.DisplayStudentDetails();

        Console.WriteLine("\nStudent 2 Details:");
        student2.DisplayStudentDetails();

        // Updating a student's grade
        Console.WriteLine("\nUpdating Student Grades...");
        student1.UpdateGrade('A+');
        student2.UpdateGrade('B+');

        // Displaying student details after grade update
        Console.WriteLine("\nUpdated Student 1 Details:");
        student1.DisplayStudentDetails();

        Console.WriteLine("\nUpdated Student 2 Details:");
        student2.DisplayStudentDetails();

        // Displaying total number of students
        Console.WriteLine();
        Student.DisplayTotalStudents();
    }
}

