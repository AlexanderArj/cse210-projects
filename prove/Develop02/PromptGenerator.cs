using System;
using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What new thing I learned today from my personal study of the scriptures?",
        "Did I help someone with anything today?",
        "How was my job routine today?",
        "What new thing I did today?" 
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        
        return _prompts[index];

    }
    
}
