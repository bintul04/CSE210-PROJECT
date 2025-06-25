// ------------------------------------------------------------
// W02 Journal Program - Exceeding Requirements Report
//
// In addition to meeting the core requirements of the assignment,
// I have exceeded expectations in the following ways:
//
// 1. Added a timestamp to each journal entry using DateTime.Now 
//    to make entries more meaningful and realistic.
//
// 2. Enhanced the file saving and loading logic to structure entries 
//    with clear formatting, using a unique separator "~|~" to 
//    distinguish entries line by line for better file readability.
//
// 3. Included error handling to ensure the program alerts the user 
//    when loading a file that does not exist or is improperly formatted.
//
// 4. Encapsulated all display logic within the Entry class using a 
//    Display() method to follow the principle of abstraction and make 
//    Journal’s DisplayAll() method simpler and cleaner.
//
// 5. Improved user experience with clear prompts, spacing, and feedback 
//    messages after actions like save, load, or write entry.
//
// These enhancements demonstrate creativity, professional structure, 
// and strong use of object-oriented principles such as abstraction.
//
// ------------------------------------------------------------


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    quit = true;
                    Console.WriteLine("Keep journaling! Goodbye! 😊\n");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number 1-5.\n");
                    break;
            }
        }
    }
}
