using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter Student's Registration Number");
        int RegNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The Student's Name");
        string SName = Console.ReadLine();
        Console.WriteLine("Enter the Mark 1");
        int Mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Mark 2");
        int Mark2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Mark 3");
        int Mark3 = Convert.ToInt32(Console.ReadLine());
        
        int AvgMarks = (Mark1 + Mark2 + Mark3)/3;
        
        Console.WriteLine($"Registration Number is {RegNo}");
        Console.WriteLine($"Name of the student is {SName}");
        Console.WriteLine($"Average Marks is {AvgMarks}");
        
        
    }
}