public class Activity 
{
    private string _activityName;
    private string _instructions;
    private int _activityTimer;

    private string _instructions2;


    public Activity(string activityName, string instructions,string instructions2,  int activityTimer)
    {
        _activityName = activityName;
        _instructions = instructions;
        _activityTimer = activityTimer;
        _instructions2 = instructions2;
    }

    public string GetActivityName()
    {
        return $"Welcome to {_activityName}";
    }

    public string GetInstructions()
    {
        return $"Instruction: {_instructions}";
    }

    public string GetInstructions2()
    {
        return $"{_instructions2}";
    }

    public int GetActivityTimerFromUser()
    {
        Console.Write($"Time Needed for {_activityName}: ");
        int timer = Int32.Parse(Console.ReadLine());
        return timer;
    }

    public int GetActivityTimer()
    {
        return _activityTimer;
    }

    public void SetActivityTimer(int timer)
    {
        _activityTimer = timer;
    }

    public void GetInfo()
    {
        Console.WriteLine();
        Console.WriteLine(GetActivityName());
        Console.WriteLine(GetInstructions());
        Console.WriteLine(GetInstructions2());
        Console.WriteLine();
    }

    public void EndingMessage()
{
    Console.WriteLine();
    Console.WriteLine($"You completed {_activityName}");
    Console.WriteLine($"You spent {_activityTimer} seconds on this activity");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}
}