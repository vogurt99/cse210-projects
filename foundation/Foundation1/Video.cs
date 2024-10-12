using System;

class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments;

    public string VideoTitle
    {
        get { return _videoTitle; }
        set { _videoTitle = value; }
    }
    public string VideoAuthor
    {
        get { return _videoAuthor; }
        set { _videoAuthor = value; }
    }
    public int VideoLength
    {
        get { return _videoLength; }
        set { _videoLength = value; }
    }
    public List<Comment> Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    public Video(string videoTitle, string videoAuthor, int videoLength, List<Comment> comments)
    {
        VideoTitle = videoTitle;  
        VideoAuthor = videoAuthor; 
        VideoLength = videoLength;
        Comments = comments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {VideoTitle}");
        Console.WriteLine($"Video Author: {VideoAuthor}");
        Console.WriteLine($"Video Length: {VideoLength} seconds");

        Console.WriteLine($"{CountComments()} Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
    }

    public int CountComments()
    {
        return Comments.Count;
    }
}