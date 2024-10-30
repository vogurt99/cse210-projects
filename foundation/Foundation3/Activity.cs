using System;

public class Activity
{
    private double _distance;
    private double _time;
    private DateTime _date = DateTime.Now;

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }
    public double Speed
    {
        get { return CalculateSpeed(); }
    }
    public double Pace
    {
        get { return CalculatePace(); }
    }
    public double Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public Activity(double distance, double time, DateTime date)
    {
        _distance = distance;
        _time = time;
    }

    public virtual double CalculateSpeed()
    {
        return Math.Round(Distance / (Time / 60), 2);
    }
    public double CalculatePace()
    {
        return Math.Round(60 / Speed, 2);
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"{Date:dd MMM yyyy} - Running ({Time} min): Distance: {Distance} km, Speed: {Speed} kph, Pace: {Pace} min per km");
    }
}