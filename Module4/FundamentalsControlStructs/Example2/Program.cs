using System;

class Example2 {
    static void Main(string[] args) {
        Console.WriteLine("Select and option:\n\tWater:\n\tSoda:\n\tCoffee:");
        Console.Write("> ");
        string button = Console.ReadLine();

        switch (button)
        {
            case "Water":
            case "water":
                Console.WriteLine("Dispensing water.");
                break;
            case "Soda":
            case "soda":
                Console.WriteLine("Dispensing soda.");
                break;
            case "Coffee":
            case "coffee":
                Console.WriteLine("Dispensing coffee.");
                break;
            default:
                Console.WriteLine("Wrong option.");
                break;
        }
    }
}