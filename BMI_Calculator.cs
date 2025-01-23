using System;

class BMI_Calculator
{
    static void Main()
    {
        // Get user input for weight (in kg) and height (in cm)
        Console.Write("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from cm to meters
        double heightInM = heightInCm / 100;

        // Calculate BMI using the formula: BMI = weight / (height * height)
        double bmi = weight / (heightInM * heightInM);

        // Output the BMI value using string.Format
        Console.WriteLine(string.Format("Your BMI is: {0:F2}", bmi));

        // Determine the weight status based on BMI value
        if (bmi <= 18.4)
        {
            Console.WriteLine("Weight Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Weight Status: Normal");
        }
        else if (bmi >= 25 && bmi <= 39.9)
        {
            Console.WriteLine("Weight Status: Overweight");
        }
        else if (bmi >= 40)
        {
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
