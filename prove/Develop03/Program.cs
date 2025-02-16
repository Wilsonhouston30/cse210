using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string userinput = " ";
        Scripture scripture = new Scripture("John",3,16,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");
        
        Console.ReadLine();
        Console.Clear();

        bool completed = false;

        while (!completed && userinput.ToUpper() != "QUIT")
        {

            Console.WriteLine(scripture.GetVerse());

            if (userinput.ToUpper() != "QUIT")
            {
                completed = scripture.HideScripture();
                userinput = Console.ReadLine();
                Console.Clear();
            }

        }
        Console.WriteLine("Done");

        Console.ReadKey();


    }
}