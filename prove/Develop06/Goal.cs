using System;
using System.ComponentModel;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }
    
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    
    public abstract string GetStringRepresentation();
}