using System;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }

    private void Run()
    {
        Console.Clear();

        Console.WriteLine("Get ready...");

        ShowSpinner(4);

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe in... {i}");
                Thread.Sleep(1000);
            }

            Console.Write("\rBreathe in...      ");

            Console.WriteLine(); 

            Console.Write("Breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe out... {i}");
                Thread.Sleep(1000);
            }

            Console.Write("\rBreathe out...      ");

            Console.WriteLine(); 

            elapsedTime += 10;
        }
    }
}