using System.Security.Cryptography.X509Certificates;

public class ListeningActivity : Activity
{
    public ListeningActivity(int timer) : base ("Listening Activity","Quickly answer the promts as they pop up, before time expires",
    "Enter as many inputs till the timer runs out ",timer)
    {

    }

    public List <string> _promts = new List<string> 
    {
        "Name the people in your life you appreciate", 
        "What items do you value?", 
        "During a zombie appoculups who are you bring in?",
        "Mr Beast Gave you $1,000,000,000, who are you calling to share the news?",
        "You have 1 minute to grab any item at Walmart and take it home for free, which items are you adding to you cart?", 
        "Name everybody that you know",
        "Name all the snacks that you've eaten in your lifetime",
        "Name all the items inside your pantry and refridgerator",
        "Who are the people you are inviting to your private yatch",
        "Who are the people that you made can rely on",
        "What teachers/professors made an impact on your education",
        "What are you grateful for?",     

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

        EndingMessage();


    }



}