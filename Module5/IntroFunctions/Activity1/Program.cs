using System;

public class Program
{
    // Example 1
    public static double CalculateRectangleArea(double length, double width) {
        double area = length * width;
        return area;
    }

    public static void Main(string[] args)
    {
        // Example 1
        double length, width;

        Console.Write("Enter length of the rectangle: ");
        length = double.Parse(Console.ReadLine());

        Console.Write("Enter width of the rectangle: ");
        width = double.Parse(Console.ReadLine());

        double area = CalculateRectangleArea(length, width);

        Console.WriteLine($"The area of the rectangle with length: {length} and width: {width} is: {area}");
    }
}
