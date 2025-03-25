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

    // Example 3:
    static void GradingSystem(int grade) {
        if (grade >= 90) {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80) {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70) {
            Console.WriteLine("Grade: C");
        }
        else {
            Console.WriteLine("Grade: D");
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

        Console.WriteLine("-------------------------------");

        // Example 3
        int grade;
        Console.Write("Enter current grade: ");
        grade = Convert.ToInt32(Console.ReadLine());

        GradingSystem(grade);
    }
}