public class ReflectingActivity : Activity
{
    public ReflectingActivity(int timer)
    : base ("Reflecting Activity", "Answer the promt, similar to a journal", "Hit enter to move on to next promt, continue till timer expires ",timer)
    {

    }

    public List<string> reflectingPromts = new List<string>
     {"Would your younger self be proud of you?", 
     "What are your biggest strengths? How can you use them to achieve your goals?",
    "What is one area of your life that could use more organization? How can you improve it?",
    "What did you do last week, and what do you want to do this weekend",
    "Who do you spend the most time with at the moment? What's your favorite thing about him/her",
    "What happened recently that made you smile?", "If you had to choose to eat lunch with, who would it be?",
    "What are you grateful for and why?",
    "Describe a recent challenge that you overcame and how you did it.",
    "Whats is the most important thing you learned personally?",
    "what do you have now that you dreamed of having years ago?",
    "When someone gives you a compliment, do you say 'thank you' or refuse it? Why?",
    "What a vivid memory that you had from your childhood?",
    "Write out one sentence that describes you ",
    "What's a meal that you would like to try this instance, and why?",
    "What are you doing now that you wish to improve on?",
    "Who was was your most talked to person this time last year and who is it now?",
    "",};       

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


        int inputCount = 0;

        int duration = GetActivityTimer();
 
        DateTime endTimer = DateTime.Now.AddSeconds(duration);

        var responses = new List<(string input, string prompt)>();

        while (DateTime.Now < endTimer)
        {
            string prompt = DisplayPromt(); 

            Console.WriteLine($"Promt: {prompt} ");
            Console.Write("> ");
            string input = Console.ReadLine();
            inputCount ++;

            responses.Add((input, prompt));
            Console.Clear();

            
        }

        Console.WriteLine($" Times Up! You reflected on {inputCount} promts");
        foreach(var response in responses)
        {
            Console.WriteLine($"Prompt: {response.prompt}");
            Console.WriteLine($"Response: {response.input}");
            Console.WriteLine();
        }


        EndingMessage();
    }


    

    
}