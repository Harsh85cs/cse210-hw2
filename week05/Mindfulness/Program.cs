using System;

// This program exceeds requirements by keeping a log of how many times
// each activity has been performed during the session.

class Program
{
    static void Main(string[] args)
    {
        int breathCount = 0, reflectCount = 0, listCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"\nSession log -> Breathing: {breathCount} | Reflecting: {reflectCount} | Listing: {listCount}");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                breathCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                reflectCount++;
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                listCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}