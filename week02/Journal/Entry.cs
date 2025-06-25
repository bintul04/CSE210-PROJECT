using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public Entry(string promptText, string entryText, string date)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    public string GetDate() => _date;
    public string GetPrompt() => _promptText;
    public string GetEntry() => _entryText;
}
