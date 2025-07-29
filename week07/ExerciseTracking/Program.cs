// "Program.cs": """
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("04 Nov 2024", 30, 3.0),
            new Cycling("04 Nov 2024", 45, 15.0),
            new Swimming("04 Nov 2024", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}