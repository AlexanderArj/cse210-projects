using System;
using System.Threading;

// I added a function to make the user hold their breath for 15 seconds if the activity time is longer than 60 seconds

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int firstBreath = 1;

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(); // 
            Console.WriteLine();


            if (_duration >= 60 && firstBreath !=0 )
            {
                Console.WriteLine("Hold your breath...");
                
                for (int i = 15; i > 0; i--)
                {
                    Console.Write($"{i:00}");
                    Thread.Sleep(1000);
                    Console.Write("\r");
                }
                Console.Write("  ");

                firstBreath = 0;
            }

            Console.WriteLine();

            Console.Write("Breathe out...");
            Console.WriteLine();
            ShowCountDown();
        }

        Console.WriteLine("Well done");
        ShowSpinner();
        DisplayEndingMessage();
        ShowSpinner();
    }
}
