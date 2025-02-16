public class Word
{

    private string word; // storing the word in the scripture

    private bool hidden; // indicator on whether the word is hidden or not

     public bool IsHidden => hidden;


    public Word(string Word)
    {
        word = Word; // initializes the word with Word
        hidden = false; // initalilly the word isn't hidden
    }

    public string GetWord()
    {
        return hidden ? new string ('_', word.Length) : word;
    }
    public bool HideWord()
    {
        if (!hidden)
        {
            hidden = true;
            return hidden;
        }
        return false;
    }
}