public class Entry
{
    public string _propmt;

    public string _repponse;

    public string _date;


    // intialize the Entry class 
    public Entry (string prompt, string response, string date)
    {
        this._propmt = prompt;
        this._repponse = response;
        this._date = date;
    }


    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Promt: {_propmt}");
        Console.WriteLine($"Response: {_repponse} - {_date}");
        Console.WriteLine();

    }

}