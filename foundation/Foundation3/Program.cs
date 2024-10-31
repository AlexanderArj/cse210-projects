using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> _activities = new List<Activity>
        {
            new Running(new DateTime(2024, 1, 3), 3, 3.0),

            new Cycling(new DateTime(2024, 11, 4), 4, 15.0),
            
            new Swimming(new DateTime(2024, 11, 5), 50, 20)
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
