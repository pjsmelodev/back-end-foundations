using System;

class VendingMachine {
    static void VendingMch(string choice) {
        switch (choice) {
            case "Water":
            case "water":
                Console.WriteLine("Dispensing water...");
                break;
            case "Soda":
            case "soda":
                Console.WriteLine("Dispensing soda...");
                break;
            case "Coffee":
            case "coffee":
                Console.WriteLine("Dispensing coffee...");
                break;
            default:
                Console.WriteLine("Wrong option!");
                break;
        }
    }

    static void Main(string[] args) {
        string choice;

        Console.WriteLine("Options:\nWater\nSoda\nCoffee");
        choice = Console.ReadLine();

        VendingMch(choice);
    }
}