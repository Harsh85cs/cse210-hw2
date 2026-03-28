using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference ref1 = new Reference("John", 3, 16);
        scriptures.Add(new Scripture(ref1,
        "For God so loved the world that he gave his only begotten Son"));

        Reference ref2 = new Reference ("Moroni", 10, 3, 5);
        scriptures.Add(new Scripture(ref2,
        "Behold I would exhort you that when ye shall read these things " +
        "if it be wisdom in God that ye should read them that ye would " +
        "remember how merciful the Lord hath been unto the children of men " +
        "from the creation of Adam even down until the time that ye shall " +
        "receive these things and ponder it in your hearts and when ye shall " +
        "receive these things I would exhort you that ye would ask God the " +
        "Eternal Father in the name of Christ if these things are not true " +
        "and if ye shall ask with a sincere heart with real intent having " +
        "faith in Christ he will manifest the truth of it unto you by the " +
        "power of the Holy Ghost and by the power of the Holy Ghost ye may " +
        "know the truth of all things"));
        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words are hidden. Goodbye!");
        }
        else
        {
            Console.WriteLine("\nGoodbye!");
        }
        }
    }
