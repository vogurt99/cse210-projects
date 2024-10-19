using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
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

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {selectedPrompt} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");

        string userInput = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        ShowCountDown(5);

        Console.Clear();

        Random random2 = new Random();
        int totalElapsedTime = 0;
        int spinnerDuration = 10;

        while (totalElapsedTime < Duration) 
        {
            int randomIndex2 = random2.Next(_questions.Count);
            string selectedQuestion = _questions[randomIndex2];

            Console.Write($"{selectedQuestion} ");
            
            ShowSpinner(spinnerDuration);

            Console.WriteLine();

            totalElapsedTime += spinnerDuration;

            if (totalElapsedTime >= Duration)
            {
                break;
            }
        }
    }
}