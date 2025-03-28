using System;

public class Program {
   public static void Main() {
        Console.WriteLine("Enter your income:");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Are you a resident? (yes/no):");
        string residentInput = Console.ReadLine();
        bool isResident = residentInput.ToLower() == "yes";

        double taxRate = 0;
        double tax;

        if (income < 50000) {
            if (isResident) {
                taxRate = 0.10; 
            } else {
                taxRate = 0.15; 
            }
        } else if (income >= 50000 && income <= 100000) {
            if (isResident) {
                taxRate = 0.20; 
            } else {
                taxRate = 0.25; 
            }
        } else {
            if (isResident) {
                taxRate = 0.30; 
            } else {
                taxRate = 0.35; 
            }
        }

        tax = income * taxRate;
        Console.WriteLine("The tax is: $" + tax);
    }
}