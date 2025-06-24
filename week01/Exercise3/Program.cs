using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain;

        Console.WriteLine("Welcome to the Guess My Number game! 🎉");

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("\nI have picked a number between 1 and 100. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Validate input to be an integer between 1 and 100
                bool isValid = int.TryParse(input, out guess);
                if (!isValid || guess < 1 || guess > 100)
                {
                    Console.WriteLine("Oops! Please enter a whole number between 1 and 100.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher 🔼");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower 🔽");
                }
                else
                {
                    Console.WriteLine($"You guessed it! 🎉 It took you {guessCount} guesses.");
                }
            }

            Console.Write("\nWant to play again? (yes/no): ");
            playAgain = Console.ReadLine()?.Trim().ToLower() ?? "no";

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Hope you had fun.");
    }
}
