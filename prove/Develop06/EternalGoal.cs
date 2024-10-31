using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) 
    {
    }

    public override void RecordEvent(ref int score)
    {
        score += Points;
        Console.WriteLine("Eternal goal recorded! You earned " + Points + " points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "[ ] " + ShortName + " (" + Points + " points each time)";
    }

    public override string GetStringRepresentation()
    {
        return "EternalGoal:" + ShortName + "," + Description + "," + Points;
    }
}
