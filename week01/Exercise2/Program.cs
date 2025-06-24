// using System;

// class Program
// {
//     static void Main()

//     {
//         // 1. Ask for user input
//         Console.Write("Enter your grade percentage: ");
//         string input = Console.ReadLine();
//         int grade = int.Parse(input);

//         // 2. Declare variables
//         string letter;
//         string sign = "";

//         // 3. Determine letter grade
//         if (grade >= 90)
//         {
//             letter = "A";
//         }
//         else if (grade >= 80)
//         {
//             letter = "B";
//         }
//         else if (grade >= 70)
//         {
//             letter = "C";
//         }
//         else if (grade >= 60)
//         {
//             letter = "D";
//         }
//         else
//         {
//             letter = "F";
//         }

//         // 4. Determine sign (only if not an F)
//         int lastDigit = grade % 10;

//         if (letter != "F")
//         {
//             if (lastDigit >= 7)
//             {
//                 sign = "+";
//             }
//             else if (lastDigit < 3)
//             {
//                 sign = "-";
//             }
//         }

//         // 5. No A+ allowed
//         if (letter == "A" && sign == "+")
//         {
//             sign = "";
//         }

//         // 6. Print the grade
//         Console.WriteLine($"Your letter grade is: {letter}{sign}");

//         // 7. Pass/fail message
//         if (grade >= 70)
//         {
//             Console.WriteLine("Congratulations! You passed the course");
//         }
//         else
//         {
//             Console.WriteLine("Keep going, You’re getting closer every step!");
//         }
//     }
// }













class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int grade;
        while (!int.TryParse(Console.ReadLine(), out grade))
        {
            Console.WriteLine("Invalid input. Please enter a valid grade percentage.");
        }

        string letter = "";
        char sign = '+';
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        if (grade < 30) sign = '-';
        else if (grade % 10 >= 7) sign = '+';

        if (letter == "A" && sign == '+')
        {
            Console.WriteLine("Your grade is A.");
        }
        else if (letter == "F")
        {
            Console.WriteLine("Your grade is F.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is: {letter}{sign}");
        }
    }
}