using System;

public class Program
{
    // Example 1
    public static int AddNumbers(int a, int b) {
        return a + b;
    }

    // Problem 1
    public static decimal TrapezoidArea(decimal a, decimal b, decimal height) {
        return (a + b) / 2 * height;
    }

    public static void Main(string[] args)
    {
        // Example 1
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        int sum = AddNumbers(a, b);

        Console.WriteLine($"{a} + {b} = {sum}");

        // Problem 1
        Console.Write("Enter length of the fist parallel side: ");
        decimal sideA = decimal.Parse(Console.ReadLine());

        Console.Write("Enter length of the second parallel side: ");
        decimal sideB = decimal.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal areaTrap = TrapezoidArea(sideA, sideB, height);
        Console.WriteLine($"Parallel side A: {sideA}\nParallel side B: {sideB}\nHeight: {height}\nArea: {areaTrap}"); 
    }
}