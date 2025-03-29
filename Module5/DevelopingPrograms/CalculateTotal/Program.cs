using System;

public class Program
{
    public static int CalculateTotalPrice(int[] itemPrices) {
        int total = 0;

        foreach (int price in itemPrices)
        {
            total += price;
        }

        return total;
    }

    public static void Main(string[] args)
    {
        int[] prices = {15, 16, 18, 19};
        int total = CalculateTotalPrice(prices);

        Console.WriteLine("Total: " + total);
    }
}