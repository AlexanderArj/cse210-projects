using System;

public class CheckListGoal : Goal
{
    private int amountCompleted = 0;
    private int target;
    private int bonus;

    public int GetAmountCompleted()
    {
        return amountCompleted;
    }

    public int GetTarget()
    {
        return target;
    }

    public int GetBonus()
    {
        return bonus;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        this.target = target;
        this.bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (amountCompleted < target)
        {
            amountCompleted++;
            score += Points;

            if (amountCompleted == target)
            {
                score += bonus;
                Console.WriteLine("Checklist Goal completed! You earned a bonus of " + bonus + " points.");
            }
            else
            {
                Console.WriteLine("Checklist Goal progress: " + amountCompleted + "/" + target + ". You earned " + Points + " points.");
            }
        }
    }

    public override bool IsComplete()
    {
        return amountCompleted >= target;
    }

    public override string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "X";
        }
        else
        {
            status = " ";
        }

        return "[ " + status + " ] " + ShortName + " (Completed " + amountCompleted + "/" + target + " times, Bonus: " + bonus + " points)";
    }

    public override string GetStringRepresentation()
    {
        return "CheckListGoal:" + ShortName + "," + Description + "," + Points + "," + target + "," + bonus;
    }
}
