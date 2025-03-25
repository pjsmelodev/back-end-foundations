using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> ages = new List<int> { 5, 12, 15, 18, 25, 30, 40, 8, 14, 19 };

        List<int> children = new List<int>();
        List<int> teens = new List<int>();
        List<int> adults = new List<int>();

        foreach (int age in ages)
        {
            if (age < 13)
            {
                children.Add(age);
            }
            else if (age >= 13 && age <= 19)
            {
                teens.Add(age);
            }
            else
            {
                adults.Add(age);
            }
        }

        Console.WriteLine("Children: " + string.Join(", ", children));
        Console.WriteLine("Teens: " + string.Join(", ", teens));
        Console.WriteLine("Adults: " + string.Join(", ", adults));
    }
}
