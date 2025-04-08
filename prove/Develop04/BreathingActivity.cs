using System.Runtime.CompilerServices;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int timer) 
    : base ("Breathing Activity", "Follow the instructions that will slowly prompt you to breath in and out...", " ",timer)
    {

    }

    public void StartBreathingActivity()
    {
        GetInfo();
        SetActivityTimer(GetActivityTimerFromUser());
        int duration = GetActivityTimer();
        DateTime endTime = DateTime.Now.AddSeconds(duration);



        // runing breathing cycles till end of duration 

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in....");
            for (int i = 4;i > 0 ;i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Breath out....");
            for (int i = 6; i > 0;i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        }

        EndingMessage();

    }

}
