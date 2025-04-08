public class ReflectingActivity : Activity
{
    public ReflectingActivity(int timer)
    : base ("Reflecting Activity", "Answer the promt, similar to a journal", "Hit enter to move on to next promt, continue till timer expires ",timer)
    {

    }

    public List<string> reflectingPromts = new List<string>
     {"Would your younger self be proud of you?", "What are your biggest strengths? How can you use them to achieve your goals?",
    "What is one area of your life that could use more organization? How can you improve it?",
    "What did you do last week, and what do you want to do this weekend",
    "Who do you spend the most time with at the moment? What's your favorite thing about him/her",
    "What happened recently that made you smile?", "If you had to choose to eat lunch with, who would it be?"};       

    private Random random = new Random();

    public string DisplayPromt()
    {
        int randomIndex = random.Next(0, reflectingPromts.Count);
        string randomPrompt = (reflectingPromts[randomIndex]);
        return randomPrompt;
    }

    public void StartReflectingActivity()
    {
        GetInfo();
        SetActivityTimer(GetActivityTimerFromUser());

        string promt = DisplayPromt();
        int inputCount = 0;

        int duration = GetActivityTimer();

        DateTime endTimer = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTimer)
        {
            Console.WriteLine($"Promt: {promt} ");
            Console.Write("> ");
            string input = Console.ReadLine();
            inputCount ++;
        }

        Console.WriteLine($" Times Up! You reflected on {inputCount} promts");

        
    }
    

    
}