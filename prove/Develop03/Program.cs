using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference scriptureReference = new Reference("John", 3, 16, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        DisplayScriptureWithReference(scriptureReference, scripture);

        // Loop until all words are hidden.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();
            
            // Hide one random word.
            scripture.HideRandomWords(1);

            // Display the scripture again with the random word hidden.
            DisplayScriptureWithReference(scriptureReference, scripture);
        }
    }

    static void DisplayScriptureWithReference(Reference scriptureReference, Scripture scripture)
    {
        string scriptureText = GetScriptureTextWithHiddenWords(scripture);
        Console.WriteLine($"{scriptureReference.GetDisplayText("")} {scriptureText}");
    }

    // Replace hidden words with underscores in the scripture text.
    static string GetScriptureTextWithHiddenWords(Scripture scripture)
    {
        List<Word> words = scripture.GetWords();
        string concatenatedWords = "";

        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                // the + " " prevents the space between each word from becoming an underscore too.
                concatenatedWords += new string('_', word.GetDisplayText().Length) + " ";
            }
            else
            {
                concatenatedWords += word.GetDisplayText() + " ";
            }
        }

        return concatenatedWords.Trim();
    }
}