using System;

class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base (shortName, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description})";
    }
}