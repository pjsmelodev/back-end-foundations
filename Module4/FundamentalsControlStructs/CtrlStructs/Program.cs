using System;

class Program {
    static void CheckTricketPrice(int age) {
        if (age < 12)
        {
            Console.WriteLine("Half price ticket.");
        }
        else if (age >= 12 && age <= 65) {
            Console.WriteLine("Full price ticket.");
        }
        else {
            Console.WriteLine("Senior discount ticket.");
        }
    }

    static void Main(string[] args) {
        int age;

        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        CheckTricketPrice(age);
    }
}