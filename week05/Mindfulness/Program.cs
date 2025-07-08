// EXCEEDS REQUIREMENTS:
// - Added a new "Gratitude Activity" option with unique gratitude-based prompts to promote emotional reflection.
// - Implemented prompt shuffling without repetition during the session.
// - Integrated smooth countdown and spinner animations for a more engaging experience.
// - Ensured all user input is dynamic (e.g., duration selection), consistent with other activities.
// - Updated the menu to include 5 clearly numbered choices for better user experience.
// - Followed OOP principles by extending the base Activity class and overriding behavior specifically for gratitude.

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
        }
    }
}
