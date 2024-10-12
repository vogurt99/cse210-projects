using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Title 1", "Author 1", 650, new List<Comment>
            {
                new Comment("User1", "Great video!"),
                new Comment("User2", "Very informative."),
                new Comment("User3", "Loved the editing!")
            }),
            new Video("Title 2", "Author 2", 225, new List<Comment>
            {
                new Comment("User4", "This helped me a lot."),
                new Comment("User5", "Well explained."),
                new Comment("User6", "Good work!"),
                new Comment("User7", "Amazing content!"),
            }),
            new Video("Title 3", "Author 3", 1049, new List<Comment>
            {
                new Comment("User8", "Keep up the good work!"),
                new Comment("User9", "Really enjoyed watching this."),
                new Comment("User10", "Saved me so much time!")
            })
        };

        foreach (var video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}