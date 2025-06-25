using System;

public class Job
{
    // Member variables (public for dot notation ease in this assignment)
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Display method to show job info in required format
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
