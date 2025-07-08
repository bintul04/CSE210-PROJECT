// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Test MathAssignment
        MathAssignment math = new MathAssignment("Bintu Lukulay", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        // Test WritingAssignment
        WritingAssignment writing = new WritingAssignment("Bintu Lukulay", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
