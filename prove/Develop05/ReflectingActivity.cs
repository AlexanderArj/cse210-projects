using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "-----Think of a time when you stood up for someone else-----",
        "-----Think of a time when you did something really difficult-----",
        "-----Think of a time when you helped someone in need-----",
        "-----Think of a time when you did something truly selfless-----"
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Consider the following prompt: ");
            DisplayPrompt();

            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine(); 

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");

            ShowCountDown();
            Console.WriteLine();

            DisplayQuestions();
            ShowSpinner();
        }

        DisplayEndingMessage();
        ShowSpinner();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(5000);
    }

    private void DisplayQuestions()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        Console.Write(question);
        Thread.Sleep(5000);
    }
}