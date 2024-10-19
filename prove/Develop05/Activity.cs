using System;

public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {Name}.\n");
        Console.WriteLine($"{Description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {Duration} seconds of the {Name}.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        int originalCursorPosition = Console.CursorLeft;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string[] spinnerSymbols = { "-", "\\", "|", "/","-"};
            foreach (string symbol in spinnerSymbols)
            {
                if (DateTime.Now >= endTime)
                    break;

                Console.SetCursorPosition(originalCursorPosition, Console.CursorTop);
                Console.Write(symbol);
                Thread.Sleep(200);
            }
        }

        Console.SetCursorPosition(originalCursorPosition, Console.CursorTop);
        Console.Write(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rYou may begin in... {i}");
            Thread.Sleep(1000);
        }
        Console.Write("\rYou may begin in...      ");
    }
}