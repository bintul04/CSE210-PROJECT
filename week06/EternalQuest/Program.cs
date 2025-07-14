using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        /*
         * Eternal Quest Program
         *
         * This program exceeds basic requirements by:
         * - Utilizing polymorphism for clean, extensible goal management.
         * - Persistent saving and loading of goal state and player score.
         * - Detailed display of progress with special handling of checklist goals.
         * - Bonus points awarded automatically upon checklist completion.
         * - User-friendly menu system supporting goal creation, event recording, and data persistence.
         *
         * Future creative ideas planned include adding a leveling system, badges, and penalties for negative goals.
         */

        manager.Start();
    }
}
