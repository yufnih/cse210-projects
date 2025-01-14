using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        //string magicNumberStr =  Console.ReadLine();
        //int magicNumber = int.Parse(magicNumberStr);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;

        do 
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }   while (guess != magicNumber);


    }
}