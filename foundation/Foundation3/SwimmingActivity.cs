using System;

class SwimmingActivity : Activity
{
    private int _laps;
    private double _swimmingDistance;
    private double _swimmingPace;

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }
    public double SwimmingDistance
    {
        get { return _swimmingDistance; }
        set { _swimmingDistance = value; }
    }
    public double SwimmingPace
    {
        get { return _swimmingPace; }
        set { _swimmingPace = value; }
    }

    public override double CalculateSpeed()
    {
        return Math.Round(SwimmingDistance / (Time / 60), 2);
    }

    public SwimmingActivity(double distance, double time, int laps, DateTime date) : base (distance, time, date)
    {
        _laps = laps;
    }
    public override void GetSummary()
    {
        SwimmingDistance = Laps * Distance / 1000;
        SwimmingPace = Math.Round(Time / SwimmingDistance, 2);
        Console.WriteLine($"{Date:dd MMM yyyy} - Swimming ({Time} min): Laps: {Laps}, Distance: {SwimmingDistance} km, Speed: {Speed} kph, Pace: {SwimmingPace} min per km");
    }
}