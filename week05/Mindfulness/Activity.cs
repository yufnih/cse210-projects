using System.ComponentModel.Design;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");; 
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> spinnerAnimation = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string frame = spinnerAnimation[i];
            Console.Write(frame);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i == spinnerAnimation.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(seconds);
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
}