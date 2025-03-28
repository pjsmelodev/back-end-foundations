using System;

class Practice1 {
    static void Main(string[] args) {
        int grade;

        Console.Write("Enter the student's grade: ");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 50)
        {
            Console.WriteLine("Passed.");
        }
        else {
            Console.WriteLine("Flunked.");
        }
    }
}