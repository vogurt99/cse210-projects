using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    private string _text;

    public string GetDisplayText(string scriptureText)
    {
        if (_endVerse > _verse)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
    public Reference(string book, int chapter, int verse, int endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _text = text;
    }
}