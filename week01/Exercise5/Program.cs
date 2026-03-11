using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(username, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine(" Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string usernumber = Console.ReadLine();
        int number = int.Parse(usernumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squareroot = number * number;
        return squareroot;
    }
    static void DisplayResult(string username, int squareroot)
    {
        Console.WriteLine($"{username}, the squareroot of your number is: {squareroot}");
    }
}