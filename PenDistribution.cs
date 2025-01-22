using System;

class PenDistribution
{
    static void Main()
    {
        // Define the total number of pens and students
        int totalPens = 14;
        int numberOfStudents = 3;

        // Calculate the number of pens each student will get
        int pensPerStudent = totalPens / numberOfStudents;

        // Calculate the remaining pens that are not distributed
        int remainingPens = totalPens % numberOfStudents;

        // Output the result
        Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}", pensPerStudent, remainingPens));
    }
}
