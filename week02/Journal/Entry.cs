using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    // Constructor for new entry, date set automatically
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    // Constructor for loading from file (date provided)
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // Getters
    public string GetPrompt() => _prompt;
    public string GetResponse() => _response;
    public string GetDate() => _date;

    // Display entry nicely
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}
