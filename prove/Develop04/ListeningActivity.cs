using System.Security.Cryptography.X509Certificates;

public class ListeningActivity : Activity
{
    public ListeningActivity(int timer) : base ("Listening Activity","Quickly answer the promts as they pop up, before time expires",
    "Enter as many inputs till the timer runs out ",timer)
    {

    }

    public List <string> _promts = new List<string> 
    {
        "Name the people in your life you appreciate", "What items do you value?", "During a zombie appoculups who are you bring in?" 
    };

    private Random random = new Random();

    public string DisplayPromt()
    {
        int randomIndex = random.Next(0, _promts.Count);
        string randomPromt = (_promts[randomIndex]);
        return randomPromt;
    }

    public void StartListeningActivity()
    {
        GetInfo();
        SetActivityTimer(GetActivityTimerFromUser());

        string promt = DisplayPromt();
        Console.WriteLine($"Promt: {promt}");

        int duration = GetActivityTimer();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int inputCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            inputCount++;

        }
        Console.WriteLine($" Times Up! You reflected on {inputCount} promts");


    }



}