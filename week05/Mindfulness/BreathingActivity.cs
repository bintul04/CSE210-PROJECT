
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine();
            elapsed += 6;
        }
        DisplayEndingMessage();
    }
}
