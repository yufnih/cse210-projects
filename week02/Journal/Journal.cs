//class Journal
//
//_entries: List<Entry>
//
//AddEntry(newEntry : Entry) : void
//DisplayAll() : void
//SaveToFile(file : string) : void
//LoadFromFile(file : string) : void
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (Entry i in _entries)
            {
                Console.WriteLine($"Date: {i._date} - Prompt: {i._promptText}");
                Console.WriteLine(i._entryText);
                Console.WriteLine();
            }
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},,{entry._promptText},,{entry._entryText}");
            }
        }

    }
    public Journal LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Journal newJournal = new Journal();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",,");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newJournal.AddEntry(newEntry);
        }
        return newJournal;
    }
}