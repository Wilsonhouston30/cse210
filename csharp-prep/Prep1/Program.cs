using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? "); // display's message requesting name
        string firstName = Console.ReadLine(); // saves input into the variable firstName

        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();


        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName} "); // formated the string to have set places for variables recorded
    }
}