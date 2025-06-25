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
                    Console.WriteLine("Goodbye, mi amor! Keep journaling ❤️");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number 1-5.\n");
                    break;
            }
        }
    }
}
