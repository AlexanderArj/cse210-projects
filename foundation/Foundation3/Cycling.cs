using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * Length; // miles
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // min per mile
    }
}
