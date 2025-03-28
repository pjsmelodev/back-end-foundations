using System;

class Program {
    static void Main(string[] args) {
        string accountType;

        Console.WriteLine("Options:\n\tSavings\n\tChecking\n\tBusiness");
        Console.Write("Enter account type: ");
        accountType = Console.ReadLine().ToLower();

        switch (accountType)
        {
            case "savings":
                Console.WriteLine("Interest rate: 2%.");
                break;
            case "checking":
                Console.WriteLine("Monthly fee: $10.");
                break;
            case "business":
                Console.WriteLine("Interest rate: 1% and monthly fee: $20.");
                break;
            default:
                Console.WriteLine("Error. Invalid option.");
                break;
        }
        
    }
}