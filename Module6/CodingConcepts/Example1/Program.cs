using System;

public class Program
{
    public string CalculatePassFail(int studentScore) {
        if (studentScore >= 60)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

    public string CalculateGrade(int studentScore) {
        switch (studentScore / 10)
        {
            case 10:
            case 9:
                return "A";
                break;
            case 8:
                return "B";
                break;
            case 7:
                return "C";
                break;
            case 6:
                return "D";
                break;
            default:
                return "F";
        } 
    }

    public void PrintPassFailWithGrades() {
        for (int i = 55; i <= 95; i += 10)
        {
            string passFailResult = CalculatePassFail(i);

            string grade = CalculateGrade(i);
            Console.WriteLine($"Score: {i}, Result: {passFailResult}, Grade: {grade}");
        }
    }

    public static void Main(string[] args)
    {
        // Não são static, por isso tenho de instanciar (usando a class)
        Program program = new Program();   

        program.PrintPassFailWithGrades();
    }
}