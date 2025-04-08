using System;
using System.ComponentModel.Design;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
        static void DisplayMenu()  // function that displays menu
        {
            string [] menu = {"Breathing Activity", "Listening Acitivity", "Reflection Activity", "Done"};
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
            Console.Write("Please select an option: ");
        }

        //DisplayMenu();
        int userInput =-1;
        //int userInput = Int32.Parse(Console.ReadLine()); // retrieves the user's selection outside of menu function
        Loading loading1 = new Loading();

        while (userInput != 4)
        {
            DisplayMenu();
            userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                loading1.LoadAnimation();
                BreathingActivity a1 = new BreathingActivity(0);

                a1.StartBreathingActivity();
            }

            if (userInput == 2)
            {
                loading1.LoadAnimation();
                
                ListeningActivity l1 = new ListeningActivity(0);
                l1.StartListeningActivity();
            }

        }

        



        
    }
}