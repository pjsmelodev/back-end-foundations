using System;

class TryParse {
    static void Main(string[] args) {
        string myVariable = "123";

        if (int.TryParse(myVariable, out int number)) {
            Console.WriteLine($"Conversion successful: {number}");
        }
        else {
            Console.WriteLine($"Conversion failed");
        }
    }
}