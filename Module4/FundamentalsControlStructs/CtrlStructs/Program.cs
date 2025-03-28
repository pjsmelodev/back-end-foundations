using System;

class Program {
    static void CheckTricketPrice(int age) {
        if (age < 12)
        {
            Console.WriteLine("Half price ticket.");
        }
        else if (age >= 12 && age <= 65) {
            Console.WriteLine("Full price ticket.");
        }
        else {
            Console.WriteLine("Senior discount ticket.");
        }
    }

    static void TravelMode(string mode) {
        switch (mode)
        {
            case "Bus":
            case "bus":
                Console.WriteLine("Booking a bus ticket.");
                break;
            case "Train":
            case "train":
                Console.WriteLine("Booking a train ticket.");
                break;
            case "Flight":
            case "flight":
                Console.WriteLine("Booking a flight ticket.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
                break;
        }
    }

    static void Main(string[] args) {
        int age;

        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        string mode;

        Console.Write("Select a travel mode: ");
        mode = Console.ReadLine();

        CheckTricketPrice(age);

        TravelMode(mode);
    }
}