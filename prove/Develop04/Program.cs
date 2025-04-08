using System;
using System.ComponentModel.Design;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Loading loading1 = new Loading();
        loading1.LoadAnimation();        
        Console.WriteLine("Welcome to Mindfulnes a program that keeps you grounded ");
        static void DisplayMenu()  // function that displays menu
        {
            string [] menu = {"Breathing Activity", "Listening Acitivity", "Reflection Activity", "Scoreboard","Done"};
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
            Console.Write("Please select an option: ");
        }

        //DisplayMenu();
        int userInput =-1;

        while (userInput != 5)
        {
            DisplayMenu();
            userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                loading1.LoadAnimation();

                BreathingActivity a1 = new BreathingActivity(0);
                a1.StartBreathingActivity();
            }

            else if (userInput == 2)
            {
                loading1.LoadAnimation();
                
                ListeningActivity l1 = new ListeningActivity(0);
                l1.StartListeningActivity();
            }

            else if(userInput == 3)
            {
                loading1.LoadAnimation();

                ReflectingActivity r1 = new ReflectingActivity(0);
                r1.StartReflectingActivity();
                
            }

            else if(userInput == 4)
            {
                Console.WriteLine("ScoreBoard");
            }

            else
            {
                Console.WriteLine("Done");
            }



        }

        



        
    }
}