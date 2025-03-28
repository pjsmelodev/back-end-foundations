using System;

class Program {
    static void Main(string[] args) {
        int age;
        bool isPremium;

        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Are you a premium member? (yes or no) ");
        isPremium = Console.ReadLine().ToLower() == "yes";

        if (age < 18)
        {
            if (isPremium)
            {
                Console.WriteLine("Fee: $25.");
            }
            else {
                Console.WriteLine("Fee: $15.");
            }
        }
        else if (age >= 18 && age <= 60)
        {
            if (isPremium)
            {
                Console.WriteLine("Fee: $50.");
            }
            else {
                Console.WriteLine("Fee: $30.");
            }
        }
        else
        {
            if (isPremium)
            {
                Console.WriteLine("Fee: $35.");
            }
            else {
                Console.WriteLine("Fee: $20.");
            }
        }
    }
}