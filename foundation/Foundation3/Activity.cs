using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int Length
    {
        get { return _length; }
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return _date.ToString("dd MMM yyyy") + " " + GetType().Name + " (" + _length + " min) - Distance: " + GetDistance() + ", Speed: " + GetSpeed() + ", Pace: " + GetPace();
    }
}
