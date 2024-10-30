using System;

class CyclingActivity : Activity
{
    public CyclingActivity(double distance, double time, DateTime date) : base (distance, time, date)
    {}
    public override void GetSummary()
    {
        Console.WriteLine($"{Date:dd MMM yyyy} - Cycling ({Time} min): Distance: {Distance} km, Speed: {Speed} kph, Pace: {Pace} min per km");
    }
}