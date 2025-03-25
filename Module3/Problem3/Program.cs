using System;

class Problem3 {
    static void Parity(int number) {
        if (number % 2 == 0) {
            Console.WriteLine("Even number.");
        }
        else {
            Console.WriteLine("Odd number");
        }
    }

    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Parity(number);
    }
}