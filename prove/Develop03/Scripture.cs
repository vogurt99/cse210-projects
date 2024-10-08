using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;
    private bool _completelyHidden;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        string[] wordsArray = text.Split(' ');

        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
        
        _completelyHidden = false;
    }
    public Reference GetReference()
    {
        return _reference;
    }
    public List<Word> GetWords()
    {
        return new List<Word>(_words);
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        List<Word> unhiddenWords = _words.FindAll(word => !word.IsHidden());

        numberToHide = Math.Min(numberToHide, unhiddenWords.Count);

        while (hiddenCount < numberToHide && unhiddenWords.Count > 0)
        {
            int index = rand.Next(unhiddenWords.Count);

            unhiddenWords[index].Hide();
            hiddenCount++;

            unhiddenWords.RemoveAt(index);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}