public class Loading
{

    public void LoadAnimation()
    {
        string [] animation = ["[        ]", "[/       ]", "[//      ]", "[///     ]", "[////    ]", "[/////   ]","[//////  ]","[/////// ]","[////////]"];
       foreach (string animations in animation)
       {
            Console.Clear();
            Console.WriteLine($"{animations} ... Loading");
            Thread.Sleep(1000);
       }
       Console.Clear();
       Console.WriteLine("Load Completed");
    }
}