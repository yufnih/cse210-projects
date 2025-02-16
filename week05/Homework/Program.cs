using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}