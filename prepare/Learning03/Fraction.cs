using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors

    public Fraction()  // No parameters
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) // One parameter
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // Two parameters
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom (int bottom)
    {
        _bottom= bottom;
    }

    public string GetFractionString()
    {
        return GetTop() + "/" + GetBottom();
    }

    public double GetDecimalValue()
    {
        return (double) GetTop() / GetBottom();
    }

}
