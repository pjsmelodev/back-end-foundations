using System;

class Program
{
    public static int calculateTotal(int[] items) {
        int sum = 0;

        foreach (var item in items)
        {
            sum += item;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int[] prices = {10, 3, 15, 19, 25};
        int sum = calculateTotal(prices);

        Console.WriteLine("The sum is: " + sum);
    }
}