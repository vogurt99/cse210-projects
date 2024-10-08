using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public string GetDisplayText()
    {
        return _text;
    }
    public void SetDisplayText(string text)
    {
        _text = text;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}