using System;

public class Program
{
    public static void GreetUser(string userName) {
        Console.WriteLine("Hello, " + userName + "!");
    }

    public static void Main(string[] args)
    {
        GreetUser("Paulo");
    }
}