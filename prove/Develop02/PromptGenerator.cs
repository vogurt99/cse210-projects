using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best thing that happened today?",
        "What was the worst thing that happened today?",
        "What was the most challenging thing I faced today?",
        "What am I grateful for today?",
        "What was the most fun thing I did today?",
        "What did I do today that I am proud of?"
    };


    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
}