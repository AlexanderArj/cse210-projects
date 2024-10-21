using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# lessons", "John Mayer", 300);
        Video video2 = new Video("Chess with Carlsen", "Jose Smith", 240);
        Video video3 = new Video("Visiting India", "Tomy S", 180);

        Comment comment1 = new Comment("Alyson", "Great!");
        Comment comment2 = new Comment("Olivia", "Very nice, thanks!");
        Comment comment3 = new Comment("Charlie", "I learned a lot.");

        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);

        Comment comment4 = new Comment("George", "Nice");
        Comment comment5 = new Comment("Elias", "I love chess!.");
        Comment comment6 = new Comment("Suey", "Wow!");

        video2.Comments.Add(comment4);
        video2.Comments.Add(comment5);
        video2.Comments.Add(comment6);

        Comment comment7 = new Comment("Elton", "Good explanations.");
        Comment comment8 = new Comment("Bob", "Interesting!");

        video3.Comments.Add(comment7);
        video3.Comments.Add(comment8);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideoInfo());
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.DisplayComment()} - {comment._name}");
            }
            
            Console.WriteLine();
        }
    }
}
