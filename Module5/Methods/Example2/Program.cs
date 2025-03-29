using System;
using System.Collections.Generic;

public class Program
{
    public static decimal CalculateTotal(List<decimal> prices) {
        decimal total = 0;

        for (int i = 0; i < prices.Count; i++)
        {
            total += prices[i];
        }

        return total;
    }

    public static void Main(string[] args)
    {
        List<decimal> values = new List<decimal> {15, 12, 13, 19};

        decimal total = CalculateTotal(values);

        Console.WriteLine("The total is: " + total);
    }
}