using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item != "") items.Add(item);
        }

        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
}