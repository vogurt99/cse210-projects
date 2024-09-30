using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        string entryDate = DateTime.Now.ToString("MM/dd/yyyy");

        PromptGenerator prompt = new PromptGenerator();
        string _randomPrompt = prompt.GetRandomPrompt();

        newEntry._date = entryDate;
        newEntry._promptText = _randomPrompt;
        Console.WriteLine(_randomPrompt);
        Console.Write("Type here: ");
        newEntry._entryText = Console.ReadLine();
        newEntry._entryMood = "";

        int programLoop = 0;

        while (programLoop != 1)
        {
            Console.WriteLine("What emotion did you feel while writing this?");
            Console.WriteLine("1. Happy");
            Console.WriteLine("2. Amused");
            Console.WriteLine("3. Inspired");
            Console.WriteLine("4. Annoyed");
            Console.WriteLine("5. Sad");
            Console.WriteLine("6. Angry");

            int userChoice = 0;
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                newEntry._entryMood = "Happy";
                programLoop = 1;
            }
            else if (userChoice == 2)
            {
                newEntry._entryMood = "Amused";
                programLoop = 1;
            }
            else if  (userChoice == 3)
            {
                newEntry._entryMood = "Inspired";
                programLoop = 1;
            }
            else if (userChoice == 4)
            {
                newEntry._entryMood = "Annoyed";
                programLoop = 1;
            }
            else if (userChoice == 5)
            {
                newEntry._entryMood = "Sad";
                programLoop = 1;
            }
            else if  (userChoice == 6)
            {
                newEntry._entryMood = "Angry";
                programLoop = 1;
            }
            else
            {
                Console.WriteLine("Please select a number from 1 to 6.");
            }
        }

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, file);
        
        using (StreamWriter savedEntry = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                savedEntry.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                savedEntry.WriteLine(entry._entryText);
                savedEntry.WriteLine(entry._entryMood);
            }
        }
        Console.WriteLine("Your entries have been saved to " + filePath);
    }

    public void LoadFromFile(string file)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, file);

        using (StreamReader loadEntry = new StreamReader(filePath))
        {
            string line;
            while ((line = loadEntry.ReadLine()) != null)
            {
                Entry entry = new Entry();

                entry._date = line.Substring(6, 10);
                entry._promptText = line.Substring(27);
                entry._entryText = loadEntry.ReadLine();
                entry._entryMood = loadEntry.ReadLine();

                _entries.Add(entry);
            }
        }
    }
}