using System;

class TotalNumberofHandshakes
{
    static void Main()
    {
        // Prompt the user to enter the number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula (n * (n - 1)) / 2
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Output the result using string.Format
        Console.WriteLine(string.Format("The maximum number of handshakes among {0} students is {1}.", numberOfStudents, maxHandshakes));
    }
}
