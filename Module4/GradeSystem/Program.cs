using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] grades = {85, 92, 78, 64, 89}; 

        for (int i = 0; i < grades.Length; i++) {
            int grade = grades[i]; 
            string result;

            if (grade >= 65) {
                result = "Pass";
            } else {
                result = "Fail";
            }

            Console.WriteLine($"Grade: {grade}, Result: {result}");
        }
    }
}
