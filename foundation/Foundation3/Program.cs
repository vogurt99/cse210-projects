using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity(4.8, 30, new DateTime()));
        activities.Add(new CyclingActivity(7.2, 43, new DateTime()));
        activities.Add(new SwimmingActivity(50, 1.5, 3, new DateTime()));

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}