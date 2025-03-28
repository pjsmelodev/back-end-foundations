using System;

class Program {
    static void Main(string[] args) {
        int input;

        do
        {
            Console.Write("Enter a number between 1 and 10: ");
            input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
              Console.WriteLine("Valid input: " + input);
              break;  
            }
            else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (true);
    }
}