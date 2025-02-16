public class Fraction
{
    private int _top;
    private int _bottom;


    //get for the top variable

    public int GetTop()
    {
        return _top;
    }


    public Fraction()
    {
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


}