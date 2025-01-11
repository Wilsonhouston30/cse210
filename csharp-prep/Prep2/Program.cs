using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage ");

        int percentage = Int32.Parse(Console.ReadLine()); // Converts the string thrown by Readline into int
        string grade = "F";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine();
        if (grade == "A" || grade == "B" || grade == "C" || grade == "D")
        {
            Console.WriteLine("Great work, you passed the class");
        }
        else 
        {
            Console.WriteLine("You have to retake the class");
        }


    }
}