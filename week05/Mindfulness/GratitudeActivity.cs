using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of someone who had a positive impact on your life.",
        "Recall a moment today that brought a smile to your face.",
        "What is one thing you are thankful for this week?",
        "Remember a time when you felt truly content."
    };

    public GratitudeActivity()
    {
        _name = "Gratitude Activity";
        _description = "Reflect on gratitude to boost positive emotions.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Write("How long, in seconds, would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        Random rand = new Random();
        var usedPrompts = new HashSet<int>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int index;
            do { index = rand.Next(_prompts.Count); } while (usedPrompts.Contains(index));
            usedPrompts.Add(index);

            Console.WriteLine();
            Console.WriteLine(_prompts[index]);
            ShowCountDown(5);

            if (usedPrompts.Count == _prompts.Count) usedPrompts.Clear();
        }

        DisplayEndingMessage();
    }
}
