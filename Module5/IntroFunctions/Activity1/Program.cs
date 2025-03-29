using System;

public class Program
{
    public static double CalculateRectangleArea(double length, double width) {
        return length * width;
    }

    public static double CalculateTriangleArea(double baseTri, double height) {
        return baseTri * height / 2;
    }

    public static double CircleArea(double radius) {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static void Main(string[] args)
    {
        double length, width;

        Console.Write("Enter length of the rectangle: ");
        length = double.Parse(Console.ReadLine());

        Console.Write("Enter width of the rectangle: ");
        width = double.Parse(Console.ReadLine());

        double areaRec = CalculateRectangleArea(length, width);
        Console.WriteLine($"The area of the rectangle with length: {length} and width: {width} is: {areaRec}");

        double baseTri, height;

        Console.Write("Enter the base of the triangle: ");
        baseTri = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        height = double.Parse(Console.ReadLine());

        double areaTri = CalculateTriangleArea(baseTri, height);
        Console.WriteLine($"The area of the triangle is: {areaTri}");

        double radius;

        Console.Write("Enter radius of the circle: ");
        radius = double.Parse(Console.ReadLine());

        double areaCircle = CircleArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is: {areaCircle}");
    }
}
