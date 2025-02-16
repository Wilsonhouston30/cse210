public class Verse 
{
    private List<Word> words = new List<Word>();

    public Verse(string scripture)
    {
        foreach (var word in scripture.Split(' '))
        {
            words.Add(new Word (word));
        }
    }

    public string GetVerse()
    {
        return string.Join(" ",words.Select(w => w.GetWord()));
    }

    public bool HideRandWord()
    {
        Random rand = new Random();
        bool allhidden = true;
        foreach (var word in words.Where(w => !w.IsHidden))
        {
            if (rand.Next(2) == 0)
            {
                word.HideWord();
            }
            else
            allhidden = false;
        }
        return allhidden;
    }

}