using System;

class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public string CommentAuthor
    {
        get { return _commentAuthor; }
        set { _commentAuthor = value; }
    }
    public string CommentText
    {
        get { return _commentText; }
        set { _commentText = value;}
    }
    public Comment(string commentAuthor, string commentText)
    {
        CommentAuthor = commentAuthor;
        CommentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{CommentAuthor} - {CommentText}");
    }
}