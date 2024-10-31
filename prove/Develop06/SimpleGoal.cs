using System;

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!isComplete)
        {
            isComplete = true;
            score += Points;
            Console.WriteLine("Goal completed! You earned " + Points + " points.");
        }
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "X" : " ";
        return "[ " + completionStatus + " ] " + ShortName + " (" + Points + " points)";
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + ShortName + "," + Description + "," + Points;
    }
}
