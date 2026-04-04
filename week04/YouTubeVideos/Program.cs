using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video>YoutubeListVideos = new List<Video>();
        Video video1 = new Video("pokemon","ash",300);
        video1.AddComment(new Comment("john","that's was a great video" ));
        video1.AddComment(new Comment("Lucy","that's was bad video." ));
        video1.AddComment(new Comment("jack"," that's interesting idk was the stories about it" ));
        YoutubeListVideos.Add(video1);

        Video video2 = new Video("rocksinthemountains", "peter", 1200);
        video2.AddComment(new Comment("maria","the scenery in this video is absolutely stunning!" ));
        video2.AddComment(new Comment("carlos","peter always finds the best locations" ));
        video2.AddComment(new Comment("sofia","i watched this three times already, so relaxing" ));
        YoutubeListVideos.Add(video2);

        Video video3 = new Video("C# for juniors", "moruiDev", 1900);
        video3.AddComment(new Comment("alex","this tutorial helped me understand loops finally!" ));
        video3.AddComment(new Comment("diana","best C# beginner content out there" ));
        video3.AddComment(new Comment("kevin","could you make one about classes next?" ));
        YoutubeListVideos.Add(video3);
        Video video4 = new Video("learn python in 10 minutes", "codeMaster", 600);
        video4.AddComment(new Comment("ryan","this is the clearest python intro I have ever seen!" ));
        video4.AddComment(new Comment("emma","finally understood what functions are, thank you!" ));
        video4.AddComment(new Comment("lucas","can you make a part 2 with more advanced topics?" ));
        YoutubeListVideos.Add(video4);

        foreach (Video video in YoutubeListVideos)
        {
            Console.WriteLine($"TItle:{video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetTitle()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommnetAuthor()}: {comment.GetTextCommnent()}");
            }
            Console.WriteLine("__________________________________");
        }
    }
}