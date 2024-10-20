using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 1, project!");

        string title = "Video 1";
        string author = "George Harrinson";
        string comment = "This is the video 1 test";
        double lenght = 32;

        Video video1 = new Video(title, author, lenght);
        Comment commentsVideo1 = new Comment(author, comment);

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);



    }
}