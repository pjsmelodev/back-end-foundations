using System;

public class Program
{
    public static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to our Program!");
    }

    public static void GreetUser(string name) {
        Console.WriteLine($"Hello {name}!");
    }

    public static int CalculateSum(int a, int b) {
        return a + b;
    }

    public static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        GreetUser(name);

        Console.Write("Enter first value: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second value: ");
        int b = int.Parse(Console.ReadLine());

        int sum = CalculateSum(a, b);
        Console.WriteLine($"{a} + {b} = {sum}");
    }
}