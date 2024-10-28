using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }
    public int Target
    {
        get { return _target; }
        set { _target = value; }
    }
    public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
    }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base (shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Points += base.Points;

            if (_amountCompleted == _target)
            {
                Points += _bonus;
            }
        }
        else
        {
            Console.WriteLine("Target already reached. No more points awarded.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description} - Completed {_amountCompleted}/{_target} times.";
    }
    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}