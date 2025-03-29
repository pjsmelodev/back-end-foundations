using System;

public class Program
{
    public static double CalculateDiscount(double price, double discountRate) {
        return price - (price * discountRate);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter discount rate: ");
        double discountRate = (double.Parse(Console.ReadLine()) / 100);

        Console.WriteLine("Discount: " + CalculateDiscount(price, discountRate));
    }
}