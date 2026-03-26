using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    myJournal.SaveToFile("journal.txt");
                    Console.WriteLine("Entries saved to journal.txt\n");
                    break;

                case "4":
                    myJournal.LoadFromFile("journal.txt");
                    Console.WriteLine("Entries loaded from journal.txt\n");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}

