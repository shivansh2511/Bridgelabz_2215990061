using System;

class VotingEligibility
{
    static void Main()
    {
        // Take user input for age
        Console.WriteLine("Enter the person's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check if the person is eligible to vote
        if (age >= 18)
        {
            // Output for eligible voters
            Console.WriteLine(string.Format("The person's age is {0} and can vote.", age));
        }
        else
        {
            // Output for ineligible voters
            Console.WriteLine(string.Format("The person's age is {0} and cannot vote.", age));
        }
    }
}
