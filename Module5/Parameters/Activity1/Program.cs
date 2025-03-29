using System;

public class Program
{
    // Problem 1
    public static int CalcVolume(int length, int width, int height) {
        return length * width * height;;
    }

    // Problem 2
    public static double averageThree(int a, int b, int c)  {
        // O facto do tipo de retorno ser double não força type casting é necessário usar 3.0 ou (double)
        return (a + b + c) / 3.0; 
    }

    public static void Main(string[] args)
    {
        // Problem 1
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine($"The volume of a rectangualar box with the dimensions: {length}, {width}, {height} is: {CalcVolume(length, width, height)}");

        // Problem 2
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter thrid number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"The average of: {a}, {b}, {c} = {averageThree(a,b,c)}");
    }
}