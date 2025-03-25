using System;

class Program {
    public static void Main(string[] args) {
        int age;

        Console.Write("How old are you? ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18) {
            Console.WriteLine("You are eligible to vote.");
        }
        else {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}