// _text : string
// _isHidden : bool

// Word(text : string)

// Hide() : void
// Show() : void
// IsHidden() : bool
// GetDisplayText() : string

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    } 

    public void Hide()
    {
            for (int i = 0; i < _text.Length; i++)
            {
                if (_text[i] != ' ')
                {
                    _text = _text.Remove(i, 1);
                    _text = _text.Insert(i, "_");
                }
            }
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}