using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu()
        {
            string [] options = {"New Entry","Display Current Entry",  "Save Entry" ,"Load Entry", "Quit" };
            

            for (int i = 0; i < options.Length; i++ )
            {
                Console.WriteLine($"{i+1}: {options[i]}");
            }
        }
        int menuInput = -1;
        Journal person1 = new Journal();

        Console.Clear();

        while (menuInput != 5)
        {
            DisplayMenu();
            Console.WriteLine("Select an option 1-5: ");
            menuInput = int.Parse(Console.ReadLine());

            if (menuInput < 1 || menuInput > 5)
            {
                Console.WriteLine("Please enter a number between 1-5");
            }
            else if (menuInput == 1)
            {
                person1.newEntry();
            }
            else if (menuInput == 2)
            {
               person1.DisplayEntryContent();
            }
            else if (menuInput ==3)
            {
                person1.SaveEntries();
            }
            else if (menuInput ==4)
            {
                person1.LoadEntries();
            }

        }
        Console.Clear();
        Console.WriteLine("Journal Closed");


        




        
    }
}