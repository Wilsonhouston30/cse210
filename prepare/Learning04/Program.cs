using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment_1 = new Assignment("Wilson", "Math");
        Console.WriteLine(assignment_1.GetSummary());
        MathAssignment math1 = new MathAssignment("Wilson Houston","Fractions","Math","1-10" );
        Console.WriteLine(math1.GetHomeworkList());

        WrittingAssignments writting1 = new WrittingAssignments("Malachi Houston", "Writting", "The Missing");
        Console.WriteLine(writting1.GetSummary());
        Console.WriteLine(writting1.GetWrittingInfo());

    }
}