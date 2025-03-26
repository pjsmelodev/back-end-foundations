using System;

class LargestNumber {
    static void pickLargest(int[] numbers) {
        int largestNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (largestNumber < numbers[i])
            {
                largestNumber = numbers[i];
            }
        }

        Console.WriteLine("The largest number in the list is: " + largestNumber);
    }
    static void Main(string[] args) {
        int[] numbers = {7, 2, 8, 3};

        pickLargest(numbers);
    }
}