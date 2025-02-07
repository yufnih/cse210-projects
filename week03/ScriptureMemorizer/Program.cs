using System;

//I added code to give the user an option to select which scripture they want to memorize.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference r1 = new Reference("John", 3, 16);
        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s1 = new Scripture(r1, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God. That which is born of the flesh is flesh; and that which is born of the Spirit is spirit.");
        Scripture s2 = new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine("Which scripture would you like to memorize?");
        Console.WriteLine("1.- " + r1.GetDisplayText());
        Console.WriteLine("2.- " + r2.GetDisplayText());
        Console.WriteLine("Type the number of the scripture you want to memorize:");
        Console.Write("> ");
        string scriptureNumber = Console.ReadLine();
        string input;
        if (scriptureNumber == "1")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                input = Console.ReadLine();
                if (input == "quit")
                {
                    Environment.Exit(0);
                }
                if (s1.IsCompletelyHidden() == true)
                {
                    Environment.Exit(0);
                }
                s1.HideRandomWords(2);
            } while (input != "quit");
        }
        else if (scriptureNumber == "2")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(s2.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                input = Console.ReadLine();
                if (input == "quit")
                {
                    Environment.Exit(0);
                }
                if (s2.IsCompletelyHidden() == true)
                {
                    Environment.Exit(0);
                }
                s2.HideRandomWords(3);
            } while (input != "quit");
        }
        else
        {
            Console.WriteLine("Invalid option. Please type 1 or 2.");
            Environment.Exit(0);
        }
    }
}