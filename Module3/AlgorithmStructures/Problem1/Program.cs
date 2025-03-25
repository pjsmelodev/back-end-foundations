using System;

class Problem1 {
    static void IsDiscountEligible(float totalCost) {
        if (totalCost >= 100) {
            Console.WriteLine("10% discount applied.");
            Console.WriteLine("Updated cost: " + (totalCost * 0.9));
        }
        else {
            Console.WriteLine("No discount.");
            Console.WriteLine("Cost: " + totalCost);
        }
    }

    static void Main(string[] args) {
        float totalCost;
        Console.Write("Total Cost: ");
        totalCost = Convert.ToSingle(Console.ReadLine());
        IsDiscountEligible(totalCost);
    }
}