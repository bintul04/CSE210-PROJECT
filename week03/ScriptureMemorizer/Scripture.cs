using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the scripture text into words
        string[] wordStrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in wordStrings)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        List<int> visibleIndices = new List<int>();

        // Collect indices of words still visible
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        // If fewer visible words than requested, adjust
        int toHide = Math.Min(numberToHide, visibleIndices.Count);

        while (hiddenCount < toHide && visibleIndices.Count > 0)
        {
            int randomIndexInVisible = _random.Next(visibleIndices.Count);
            int wordIndex = visibleIndices[randomIndexInVisible];
            _words[wordIndex].Hide();
            visibleIndices.RemoveAt(randomIndexInVisible);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word w in _words)
        {
            scriptureText += w.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
