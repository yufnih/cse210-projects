using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string userGradePercentage = Console.ReadLine();
        int percent = int.Parse(userGradePercentage);

        string letter = "";

        if (percent >= 90 && percent <= 100)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent < 90)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }
        else if (percent >= 0 && percent < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Input Invalid");
        }


        Console.WriteLine($"Your Grade is {letter}.");
        if (percent >= 70 && percent <= 100)
        {
            Console.WriteLine("Congratulations, you pass!");
        } 
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time!");
        }

    }
}