using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>();
    int number = 1;
    int sum = 0;
    int largest = int.MinValue;
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    do
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        else
            {
                Console.WriteLine("Invalid input, please enter a number.");
                number = -1;
            }
    } while (number != 0);

        // If no numbers entered, avoid errors
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }
        foreach (int n in numbers)
        {
            sum += n;
            if (n > largest)
                largest=n;
        }
    double average = (double)sum / numbers.Count;
    Console.WriteLine("Numbers: " + string.Join(", ", numbers));
    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Average: " + average); 
    Console.WriteLine("Largest number: " + largest);
    }
}