using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Exceeding Requirements:
    // - Implemented a library of multiple scriptures loaded from an external text file to provide variety and surprise.
    // - Scriptures are randomly selected each time the program runs, helping users practice memorizing different passages.
    // - Added functionality to hide only visible words next, improving memorization flow.
    // - Clear user instructions and graceful exit for better user experience.

    static void Main(string[] args)
    {
        // Load scriptures from a file
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in file.");
            return;
        }

        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Great job!");
                break;
            }
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }

            currentScripture.HideRandomWords(3);  // Hide 3 words each time, tweak as needed
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} not found.");
            return scriptures;
        }

        // Expected file format: One scripture per line
        // Format example: Book|Chapter|Verse|EndVerse|Text
        // Example: John|3|16|0|For God so loved the world that he gave his one and only Son...

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 5)
            {
                string book = parts[0];
                if (!int.TryParse(parts[1], out int chapter)) continue;
                if (!int.TryParse(parts[2], out int verse)) continue;
                if (!int.TryParse(parts[3], out int endVerse)) endVerse = 0;
                string text = parts[4];

                Reference reference = new Reference(book, chapter, verse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                scriptures.Add(scripture);
            }
        }
        return scriptures;
    }
}
