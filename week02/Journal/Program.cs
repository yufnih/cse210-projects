using System;

// Added code to the display funtion to tell the user if there are no entries to display.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project.");
        int userInput;

        Journal journal = new Journal();


        do 
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userInput == 1)
            {
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();
                string prompt1 = prompt.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine(prompt1);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                entry._date = "1/21/2025";
                entry._promptText = prompt1;
                journal.AddEntry(entry);
                entry.Display();
            }
            else if (userInput == 2)
            {
                journal.DisplayAll();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Please enter the file name you would like to load.");
                string loadFile = Console.ReadLine();
                Journal newJournal = journal.LoadFromFile(loadFile);
                Console.WriteLine("Loading file...");
                journal = newJournal;
                Console.WriteLine("Load complete.");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Please enter the file name you would like to save to.");
                string saveFile = Console.ReadLine();
                Console.WriteLine("Saving to file...");
                journal.SaveToFile(saveFile);
                Console.WriteLine("Save complete.");
            }

        } while (userInput != 5);
    }
}