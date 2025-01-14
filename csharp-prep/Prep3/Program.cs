using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random(); // Random class

        int magicNumber = random.Next(1, 20); // setting the magic number


        Console.WriteLine("Enter a number between 1 and 20");
        int userNumber = Int32.Parse(Console.ReadLine());

        while (userNumber != magicNumber)
        {
            if (userNumber < magicNumber)
            {
                System.Console.WriteLine("Higher");
                Console.Write("Try again: ");
                userNumber = Int32.Parse(Console.ReadLine());
            }
            else
            {
                System.Console.WriteLine("Lower");
                Console.Write("Try again: ");
                userNumber = Int32.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine(($"The number was {magicNumber}, you did it!!"));

    }
}