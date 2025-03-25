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

    static void Main(string[] args) {
        int age;

        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        VotingEligibility(age);
    }
}