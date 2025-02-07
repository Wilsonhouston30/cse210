using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Promt
{
    public List<string> _promts = new List<string> 
    {"Would your younger self be proud of you?", "What are your biggest strengths? How can you use them to achieve your goals?",
    "What is one area of your life that could use more organization? How can you improve it?",
    "What did you do last week, and what do you want to do this weekend",
    "Who do you spend the most time with at the moment? What's your favorite thing about him/her",
    "What happened recently that made you smile?", "If you had to choose to eat lunch with, who would it be?"};


    private Random random = new Random();

     public string DisplayPromt()
     {
      
        int randomIndex = random.Next(0, _promts.Count);
        string randomPrompt= (_promts[randomIndex]);
        return randomPrompt;
     }
}