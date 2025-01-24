public class Scripture
{
    // Keeps track of both the reference and the text of the scripture. 
    // Can hide words and get the rendered display of the text.

    private Reference _reference;
    private List<Word> _words;
    private bool _completelyHidden = false;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rando = new Random();

        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }

        // Ensure numberToHide doesn't exceed the number of available indexes
        numberToHide = Math.Min(numberToHide, availableIndexes.Count);

        // Randomly select indexes from the availableIndexes list
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = rando.Next(0, availableIndexes.Count);
            int wordIndex = availableIndexes[randomIndex];

            // Hide the word at the selected index
            string hiddenWord = _words[wordIndex].GetDisplayText();
            _words[wordIndex].Hide();

            // Console.WriteLine($"Hiding word: {hiddenWord}");

            // Remove the used index to avoid selecting it again
            availableIndexes.RemoveAt(randomIndex);
            if (availableIndexes.Count == 0)
            {
                _completelyHidden = true;
            }
        }
    }

    public string GetDisplayText()
    {
        string makeStringRef = _reference.GetDisplayText(); // Get the reference as a string
        string makeStringWords = string.Join(" ", _words.Select(word => word.GetDisplayText())); // Reassemble the words
        return makeStringRef + " " + makeStringWords; // Combine reference and words
    }

    public bool IsCompletelyHidden()
    {
        return _completelyHidden;
    }

}