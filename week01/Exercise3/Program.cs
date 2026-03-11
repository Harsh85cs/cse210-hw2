using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        Console.WriteLine("What is your guess for the magic number?");
        int guess2 = -1;
        while (guess2 != number)
        {
            string guess1 = Console.ReadLine();
            guess2 = int.Parse(guess1);
            if (guess2 > number)
            {
                Console.WriteLine("Go Lower");
            }
            else if (guess2 < number)
            {
                Console.WriteLine("Go Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }     
                
            
    }
}