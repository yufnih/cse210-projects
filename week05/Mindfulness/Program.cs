using System;
//I added a cute little piece of code to wish the user a "mindful" day with an animated smiley
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity(0);
        Console.WriteLine("Menu Options:");
        Console.WriteLine(  "1. Start breathing ctivity");
        Console.WriteLine(  "2. Start reflecting activity");
        Console.WriteLine(  "3. Start listing activity");
        Console.WriteLine(  "4. Quit");
        Console.Write("Select a choice from the menu: ");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Console.Clear();
            breathingActivity.DisplayStartingMessage();
            Console.Clear();
            breathingActivity.ShowCountDown(3);

            breathingActivity.Run();
            Console.WriteLine("");
            breathingActivity.DisplayEndingMessage();
        }
        else if (input == 2)
        {
            Console.Clear();
            reflectingActivity.DisplayStartingMessage();
            Console.Clear();
            reflectingActivity.ShowCountDown(3);

            reflectingActivity.Run();
            Console.WriteLine("");
            reflectingActivity.DisplayEndingMessage();
        }
        else if (input == 3)
        {
            Console.Clear();
            listingActivity.DisplayStartingMessage();
            Console.Clear();
            listingActivity.ShowCountDown(3);

            listingActivity.Run();
            Console.WriteLine("");
            listingActivity.DisplayEndingMessage();
        }        
        else if (input == 4)
        {
            Console.WriteLine("Have a mindful day!");
            Thread.Sleep(1000);
            Console.Write(":");
            Thread.Sleep(1000);
            Console.Write("]");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}