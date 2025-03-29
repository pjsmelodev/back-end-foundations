using System;

public class Program
{
    public static double CalculateDiscount(double originalPrice, double discountRate) {
        double origPrice = originalPrice;
        double discRate = discountRate;

        return origPrice * discRate;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter discount rate: (double value) ");
        double discountRate = double.Parse(Console.ReadLine());

        double discount = CalculateDiscount(price, discountRate);
        Console.WriteLine("Discount is: " + discount);
    }
}