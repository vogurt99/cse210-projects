using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
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

        Random random1 = new Random();
        int randomIndex1 = random1.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex1];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {selectedPrompt} ---");

        ShowCountDown(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        List<string> responses = new List<string>();
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
                _count++;
            }
        }

        Console.WriteLine($"You listed {_count} items.");
    }
}