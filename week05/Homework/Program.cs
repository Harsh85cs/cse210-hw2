using System;

class Program
{
    static void Main(string[] args)
    {
        Assigments assigment1 = new Assigments ("Abraham Lopez", "Molecules");
        Console.WriteLine(assigment1.GetSummary());

        MathAssigments mathAssigment = new MathAssigments("Pedro Garcia", "Fractions", "Section 7.3", "Problems 8-15");
        Console.WriteLine(mathAssigment.GetSummary());       
        Console.WriteLine(mathAssigment.GetHomeworkList());  

        WritingAssigment writingAssigment = new WritingAssigment("Maria Torres", "Romeo and Juliet", "The Tragedy of Love");
        Console.WriteLine(writingAssigment.GetSummary());          
        Console.WriteLine(writingAssigment.GetWrittingInformation()); 
    }
}