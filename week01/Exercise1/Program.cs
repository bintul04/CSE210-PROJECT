using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is Bintu Lukulay.");
        Console.WriteLine("This is in C#.");

        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        String lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");

    }
}