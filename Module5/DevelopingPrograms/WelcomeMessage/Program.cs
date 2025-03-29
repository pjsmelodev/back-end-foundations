using System;

public class Program
{
    public static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to the Program!");
    }
    
    public static void GreetUser(string user) {
        Console.WriteLine($"Hello {user}!");
    }

    public static int CalculateSum(int a, int b) {
        return a + b;
    }

    public static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        GreetUser(name);

        Console.Write("Enter your the first value: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter your the second value: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"{a} + {b} = {CalculateSum(a, b)}");
    }
}