public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Promt randomPromt = new Promt();

    public string _name;


    public void newEntry()
    {
        Console.Clear();

        // creat a variable then assign promt from Promt class
        string promt;
        promt = randomPromt.DisplayPromt();

        // Display the promt
        Console.WriteLine(promt);


        // request users response then 
        Console.Write("Enter Here ->   ");
        string response = Console.ReadLine();

        // grabs current date and time
        DateTime currentTime = DateTime.Now;
        string time = currentTime.ToShortDateString();
        


        // verification for the user
        Console.WriteLine("Entry Submitted");
        Thread.Sleep(2000);
        Console.Clear();

        //intiallizing Entry from Entry class
        Entry entry = new Entry (promt, response, time);

        _entries.Add(entry);
        Console.Clear();
    }

    public void DisplayEntryContent()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveEntries()
    {
        // sets file name to a txt file
        Console.WriteLine("Enter Jounral name: ");
        string fileName = Console.ReadLine() + ".txt";

        string content = "";
        foreach (Entry entry in _entries)
        {
            content +=$"Promt: {entry._propmt}\nEntry: {entry._repponse}/nDate: {entry._date} ";
        }
        File.WriteAllText(fileName,content);
        Console.WriteLine($"Journal Saveed as {fileName}");
    }
    public void LoadEntries()
    {
        // request file name then set the input to pull a txt file
        Console.WriteLine("Name of Journal: ");
        string loadName = Console.ReadLine() + ".txt";

        string loadedFile = File.ReadAllText(loadName);
        Console.Clear();
        Console.WriteLine(loadedFile);

    }


}