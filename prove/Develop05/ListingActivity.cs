using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    
    public ListingActivity() : base()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Get ready...");
        ShowSpinner();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("You may begin in: ");
        ShowCountDown();
        
        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Start listing items (press Enter after each one):");
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            _count++;
        }

        int exit = 1;

        do
        {
            Console.WriteLine("\nPerfect!");
            Console.WriteLine($"You listed {_count} items.");
            DisplayEndingMessage();
            ShowSpinner();
            exit = 2;

        } while( exit == 1);

        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}
