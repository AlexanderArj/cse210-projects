using System;

public class Swimming : Activity
{
    private int _laps; 

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Length) * 60; // kph
    }

    public override double GetPace()
    {
        return Length / GetDistance(); // min per km
    }
}
