using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity() { }


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(100);
                Console.Write(" ");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(" ");
        }
    }
}
