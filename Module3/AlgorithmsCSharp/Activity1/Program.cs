using System;

class Activity1 {
    // Example 1: Find the largest number in an array
    static void FindLargest(int[] numbers) {
        int largestNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++) {
            if (numbers[i] > largestNumber) { // Correct logic: compare if current number is larger
                largestNumber = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }

    // Example 2: Check if a number is even or odd
    static void CheckParity(int number) {
        if (number % 2 != 0) {
            Console.WriteLine($"{number} is odd.");
        } else {
            Console.WriteLine($"{number} is even.");
        }
    }

    // Problem 1: Sum all numbers in an array
    static void Sum(int[] numberArray) {
        int result = 0;

        foreach (int number in numberArray) {
            result += number;
        }

        Console.WriteLine($"The sum is: {result}");
    }

    // Problem 2: Count vowels in a string
    static void VowelCount(string testString) {
        int acc = 0; // Correct placement: initialize counter outside the loop

        foreach (var character in testString) {
            switch (character) {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    acc++; // Increment the counter for vowels
                    break;
            }
        }

        Console.WriteLine($"This string has {acc} vowels.");
    }

    static void Main(string[] args) {
        // Example 1
        int[] numbers = { 5, 8, 3, 4, 2 };
        FindLargest(numbers);

        // Example 2
        Console.Write("Enter an integer: ");
        int numberToCheck = Convert.ToInt32(Console.ReadLine());
        CheckParity(numberToCheck);

        // Problem 1
        int[] numbersToSum = { 5, 8, 3, 4, 2 };
        Sum(numbersToSum);

        // Problem 2
        Console.Write("Enter a string: ");
        string testString = Console.ReadLine();
        VowelCount(testString);
    }
}
