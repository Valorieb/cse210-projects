public class Word
{
    // Keeps track of a single word and whether it is shown or hidden.
    private string _text;
    private string _originalWord;
    private bool _isHidden;

    // This constructor should accept the text of the word to save it as an attribute.
    //  In addition, the constructor will need to set the initial visibility of the word
    public Word(string word)
    {
        _text = word;
        _isHidden = false;
        _originalWord = word;
    }
    public void Hide()
    {
        if (!IsHidden())
        {
            char[] charArray = _text.ToCharArray(); //change word into an array of characters
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = '_'; // replace each character with underscore
            }
            _text = new string(charArray); // Turn array back into a string
            _isHidden = true; // Mark the word as hidden
        }
    }
    public void Show()
    {
        _text = _originalWord;
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

