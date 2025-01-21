//Program to show how to read integer values
using System;

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter two Numbers:");

            //Converting string to Integer
            int Number1 = Convert.ToInt32(Console.ReadLine());

            //Converting string to Integer
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int Result = Number1 + Number2;
            Console.WriteLine($"The Sum is: {Result}");
            Console.WriteLine($"The Sum is: {Number1 + Number2}");
            Console.ReadKey();
        }
    }
}