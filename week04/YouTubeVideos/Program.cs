using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Video 1 and comments
        Video video1 = new Video("Understanding Abstraction", "Alice", 600);
        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Mary", "Helped me a lot, thanks."));
        video1.AddComment(new Comment("Sam", "Could you explain more on encapsulation?"));
        video1.AddComment(new Comment("Nina", "Loved the examples."));
        video1.AddComment(new Comment("Tom", "Very clear presentation!"));

        // Video 2 and comments
        Video video2 = new Video("Encapsulation in C#", "Bob", 450);
        video2.AddComment(new Comment("Lisa", "Nice examples!"));
        video2.AddComment(new Comment("Tom", "Clear and concise."));
        video2.AddComment(new Comment("Anna", "Looking forward to more videos."));
        video2.AddComment(new Comment("David", "This helped me with my project."));
        video2.AddComment(new Comment("Sophia", "Excellent content!"));

        // Video 3 and comments
        Video video3 = new Video("Principles of OOP", "Charlie", 900);
        video3.AddComment(new Comment("Mike", "Very informative."));
        video3.AddComment(new Comment("Nina", "Loved the practical examples."));
        video3.AddComment(new Comment("Kate", "Please make one on design patterns."));
        video3.AddComment(new Comment("Lucas", "Good pacing and explanations."));
        video3.AddComment(new Comment("Eva", "This clarified a lot for me."));

        // Video 4 and comments
        Video video4 = new Video("Advanced C# Features", "Diana", 750);
        video4.AddComment(new Comment("Mark", "This was challenging but worth it."));
        video4.AddComment(new Comment("Olivia", "Can you do more on async programming?"));
        video4.AddComment(new Comment("James", "Loved the LINQ section."));
        video4.AddComment(new Comment("Ella", "Thanks for breaking it down simply."));
        video4.AddComment(new Comment("Liam", "Looking forward to the next video!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40)); // Separator line
        }
    }
}
