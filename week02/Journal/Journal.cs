using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.\n");
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
                // Write each field on its own line, then a separator line
                writer.WriteLine(entry.GetDate());
                writer.WriteLine(entry.GetPrompt());
                writer.WriteLine(entry.GetEntry());
                writer.WriteLine("~|~");  // Entry separator
            }
        }
        Console.WriteLine($"Journal saved to file '{filename}'.\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' does not exist.\n");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        List<Entry> loadedEntries = new List<Entry>();

        for (int i = 0; i < lines.Length; i += 4)
        {
            if (i + 3 < lines.Length && lines[i + 3] == "~|~")
            {
                string date = lines[i];
                string prompt = lines[i + 1];
                string entryText = lines[i + 2];

                loadedEntries.Add(new Entry(prompt, entryText, date));
            }
            else
            {
                Console.WriteLine("File format error or incomplete entry found.");
                break;
            }
        }

        _entries = loadedEntries;
        Console.WriteLine($"Journal loaded from file '{filename}'.\n");
    }
}
