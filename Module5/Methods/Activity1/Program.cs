using System;

public class Program
{
    // Example 1
    public static int AddNumbers(int a, int b) {
        return a + b;
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
    }
}