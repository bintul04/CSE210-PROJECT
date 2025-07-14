using System;

public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _points;
    }

    public override bool IsComplete() => false; // Never complete

    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_description}) — Completed {_timesCompleted} times";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}|{_timesCompleted}";
    }

    public void SetTimesCompleted(int value)
    {
        _timesCompleted = value;
    }
}
