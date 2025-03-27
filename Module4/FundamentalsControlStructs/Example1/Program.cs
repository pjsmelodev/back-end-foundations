using System;

class Example1 {
    static void Main(string[] args) {
        int age;

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Access granted.");
        }
        else {
            Console.WriteLine("Access denied.");
        }
    }
}