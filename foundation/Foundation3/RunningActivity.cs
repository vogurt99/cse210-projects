using System;

class RunningActivity : Activity
{
    public RunningActivity(double distance, double time, DateTime date) : base (distance, time, date)
    {}
    public override void GetSummary()
    {
        base.GetSummary();
    }
}