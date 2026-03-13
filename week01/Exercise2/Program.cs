using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
            Console.WriteLine($"Congratulations, you got an {letter}");
        }
        else if (number >= 80)
        {
            letter = "B";
            Console.WriteLine($"Congratulations, you got a {letter}");
        }        
        else if (number >= 70)
        {
            letter = "C";
            Console.WriteLine($"Good job, you got a {letter}");
        }        
        else if (number >= 60)
        {
            letter = "D";
            Console.WriteLine($"You got a {letter}. Try better next time");
        }
        else if (number <= 60)
        {
            letter = "F";
            Console.WriteLine($"I'm sorry, you failed. You got an {letter}.");
        }
    }
}