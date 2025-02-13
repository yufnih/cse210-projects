using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment comment = new Comment("I love this drink!", "John Doe");
        Comment comment1 = new Comment("I hate this drink!", "Jane Doe");
        Comment comment2 = new Comment("I'm not sure about this drink.", "Smelly_Tanks");
        Comment comment3 = new Comment("I don't know man, I think this guy was paid to do this...", "VorlFace");
        Comment comment4 = new Comment("It's been a while since I've trusted any supplements in my fitness journey other than creatine and protein poweder, but I won't lie... I'm intrigued.", "");
        Comment comment6 = new Comment("Bro FitBros is overrated. They were better when they were less popular. They made better videos", "JusticeForDaijin");
        Comment comment7 = new Comment("Daddy Noel really knows how to sell me products lol", "Hanley Stanly");
        Comment comment8 = new Comment("sorry drink better when you drank with cherry flavor. pls excuse grammar am from Gebetsu", "GebetsuGamer");
        Comment comment9 = new Comment("Honestly, #3 is one of the best drinks I've had in my life", "Don'tLookAtMyProfilePicture");

        Video video = new Video("NutrixMax is the future of sport drinks.", "Shane McLay", 8);
        video.AddComment(comment);
        video.AddComment(comment1);
        video.AddComment(comment2);
        Video video1 = new Video("You will NOT believe what this drink did to my performance", "FitBros", 10);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        video1.AddComment(comment6);
        Video video2 = new Video("Top 3 supplements for your daily workouts", "Daddy Noel", 15);
        video2.AddComment(comment7);
        video2.AddComment(comment8);
        video2.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video);
        videos.Add(video1);
        videos.Add(video2);

        foreach (Video v in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {v._getTitle()}");
            Console.WriteLine($"Author: {v._getAuthor()}");
            Console.WriteLine($"Length: {v._getLength()}");
            Console.WriteLine($"Comment Count: {v.GetCommentCount()}");
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (Comment c in v._getComments())
            {
                Console.WriteLine($"Name: {c._getName()}");
                Console.WriteLine($"Text: {c._getText()}");
                Console.WriteLine();
            }
        }
    }
}