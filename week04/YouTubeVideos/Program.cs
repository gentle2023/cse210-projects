using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video video1 = new Video("Learn C# Basics", "Code Academy", 600);
        Video video2 = new Video("HTML & CSS Crash Course", "Web Dev Simplified", 900);
        Video video3 = new Video("JavaScript in 10 Minutes", "Tech World", 720);

        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Mark", "This explained a lot."));
        video1.AddComment(new Comment("Jane", "Great for beginners."));

        video2.AddComment(new Comment("Samuel", "Clean explanation."));
        video2.AddComment(new Comment("Lucy", "Loved the examples."));
        video2.AddComment(new Comment("David", "Exactly what I needed."));

        video3.AddComment(new Comment("Chris", "Short and clear."));
        video3.AddComment(new Comment("Nina", "Now I understand JS better."));
        video3.AddComment(new Comment("Paul", "Nice quick overview."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}