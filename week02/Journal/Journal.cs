using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>()
    {
        "What made me smile today?",
        "What challenge did I overcome recently?",
        "What am I grateful for right now?",
        "Who inspired me today and why?",
        "What is one thing I want to improve about myself?"
    };

    private Random _random = new Random();

    public void WriteEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);

        Console.WriteLine("Entry saved!\n");
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        Console.WriteLine("Journal Entries:\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetDate());
                writer.WriteLine(entry.GetPrompt());
                writer.WriteLine(entry.GetResponse());
                writer.WriteLine("~|~");  // separator between entries
            }
        }
        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.\n");
            return;
        }

        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4)
        {
            if (i + 3 < lines.Length && lines[i + 3] == "~|~")
            {
                string date = lines[i];
                string prompt = lines[i + 1];
                string response = lines[i + 2];

                loadedEntries.Add(new Entry(prompt, response, date));
            }
            else
            {
                Console.WriteLine("File format error.");
                break;
            }
        }

        _entries = loadedEntries;
        Console.WriteLine($"Journal loaded from {filename}\n");
    }
}
