// _reference : Reference
// _words : List<Word
// 
// Scripture(reference : Reference, text : string) 
//
// HideRandomWords(numberToHide : int) : void
// GetDisplayText() : string
// IsCompletelyHidden() : bool
//

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
      _reference = reference;
      string[] words = text.Split(" ");
      foreach (string i in words)
      {
        Word word = new Word(i);
        _words.Add(word);
      }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int index = 0;
        for (int i = 0; i < numberToHide; i++)
        {
            index = random.Next(0, _words.Count);
            while (_words[index].IsHidden() == true)
            {
                index = random.Next(0, _words.Count);
            }
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word i in _words)
        {
            text += " " + i.GetDisplayText();
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        bool hidden = false;
        int counter = 0;
        foreach (Word i in _words)
        {
            if (i.IsHidden() == true)
            {
                counter++;
            }
        }
        if (counter == _words.Count)
        {
            hidden = true;
        }
        return hidden;
    }
}