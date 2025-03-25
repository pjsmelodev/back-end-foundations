using System;

class Activity1 {
    // Example 1:
    static void VotingEligibility(int age) {
        if (age >= 18) {
            Console.WriteLine("You are eligible to vote.");
        }
        else {
            Console.WriteLine("You are not eligible to vote yet.");
        }
    }

    // Example 2:
    static void IsAdult(int age) {
        if (age >= 21) {
            Console.WriteLine("Adult wristband.");
        }
        else {
            Console.WriteLine("Minor wristband.");
        }
    }

    static void Main(string[] args) {
        // Example 1
        int age1;

        Console.Write("Enter age: ");
        age1 = Convert.ToInt32(Console.ReadLine());

        VotingEligibility(age1);

        Console.WriteLine("---------------------------");

        // Example 2
        int age2;

        Console.Write("Enter age: ");
        age2 = Convert.ToInt32(Console.ReadLine());

        IsAdult(age2);
    }
}