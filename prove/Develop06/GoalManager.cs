using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score;

    public GoalManager()
    {
        score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("You have " + score + " points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\nCurrent Score: " + score);
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        foreach (Goal goal in goals)
        {
            string completionStatus;
            if (goal.IsComplete())
            {
                completionStatus = "[X]";
            }
            else
            {
                completionStatus = "[ ]";
            }

            if (goal is CheckListGoal checklistGoal)
            {
                Console.WriteLine(completionStatus + " " + goal.ShortName + " (" + goal.Description + ") " +
                    "(Completed " + checklistGoal.GetAmountCompleted() + "/" + checklistGoal.GetTarget() + " times, Bonus: " + checklistGoal.GetBonus() + " points)");
            }
            else
            {
                Console.WriteLine(completionStatus + " " + goal.ShortName + " (" + goal.Description + ") " +
                    "(" + goal.Points + " points)");
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal would you like to create:");
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. CheckList");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (typeChoice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (typeChoice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (typeChoice == "3")
        {
            newGoal = CreateCheckListGoal(name, description, points);
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type entered.");
        }
    }

    private CheckListGoal CreateCheckListGoal(string name, string description, int points)
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter bonus points for completion: ");
        int bonus = int.Parse(Console.ReadLine());

        return new CheckListGoal(name, description, points, target, bonus);
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nEnter the goal number to record event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + goals[i].ShortName);
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            goals[choice].RecordEvent(ref score);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Well done!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save your goals: ");
        string filename = Console.ReadLine();

        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(score);
        foreach (Goal goal in goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        using StreamReader reader = new StreamReader(filename);
        score = int.Parse(reader.ReadLine());

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(':');
            var type = parts[0];
            var data = parts[1].Split(',');

            Goal goal = null;

            if (type == "SimpleGoal")
            {
                goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
            }
            else if (type == "EternalGoal")
            {
                goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
            }
            else if (type == "CheckListGoal")
            {
                goal = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
            }

            if (goal != null)
            {
                goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
