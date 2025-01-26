//class Entry 
//_date : string
//_promptText : string
//_entryText : string
//
//Display() : void

public class Entry 
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}