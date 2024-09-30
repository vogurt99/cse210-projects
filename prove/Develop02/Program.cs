// Showing Creativity and Exceeding Requirements
// Adds a new entry "_entryMood" to the journal entry, letting the user select from a list of emotions to note down how they felt when writing their entry.
// Automatically appends ".txt" to user input when saving and loading a file.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal userJournal = new Journal();
        int programLoop = 0;

        while (programLoop != 1)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            int userChoice = 0;
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Entry newEntry = new Entry();
                userJournal.AddEntry(newEntry);
            }
            else if (userChoice == 2)
            {
                userJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename? (No need to write '.txt') ");
                string fileName = Console.ReadLine();
                fileName += ".txt"; // Automatically appends.txt to the filename.
                userJournal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename? (No need to write '.txt') ");
                string fileName = Console.ReadLine();
                fileName += ".txt"; // Automatically appends.txt to the filename.
                userJournal.SaveToFile(fileName);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Quitting the Journal Program...");
                programLoop = 1;
            }
            else
            {
                Console.WriteLine("Please select a number from 1 to 5.");
            }
        }    
    }
}