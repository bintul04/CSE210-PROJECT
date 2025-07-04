using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume(string name)
    {
        _name = name;
    }

    // Add job to the list
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
