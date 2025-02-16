
public class Scripture
{
    private List<Verse> verses = new List<Verse>();
    public Scripture(string book, int chapter, int verse, string text)
    {
        verses.Add(new Verse(text));
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse)
    {

    }

    public string GetVerse()
    {
        return string.Join(" ", verses.Select(v => v.GetVerse()));
    }

    public bool HideScripture()
    {
        bool allhidden = true;
        foreach (var verse in verses)
        {
            if(!verse.HideRandWord())
            {
                allhidden = false;
            }
        }
        return allhidden;
    }
}
