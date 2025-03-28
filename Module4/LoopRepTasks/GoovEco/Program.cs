using System;

public class Program {
    public static void Main(string[] args)
    {
       double[] prices = {10.00, 15.50, 8.25, 22.00} ;

       for (int i = 0; i < prices.Length; i++)
       {
            prices[i] = prices[i] + 1.05;
            Console.WriteLine("New price for product " + i + ": " + prices[i]);
       }
    }
}