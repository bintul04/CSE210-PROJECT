// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>();
//         int userNumber = -1;

//         Console.WriteLine("Enter a list of numbers, type 0 when finished.");

//         // Collect user numbers
//         while (userNumber != 0)
//         {
//             Console.Write("Enter number: ");
//             userNumber = int.Parse(Console.ReadLine());

//             if (userNumber != 0)
//             {
//                 numbers.Add(userNumber);
//             }
//         }

//         // Step 1: Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }
//         Console.WriteLine($"The sum is: {sum}");

//         // Step 2: Compute the average
//         double average = (double)sum / numbers.Count;
//         Console.WriteLine($"The average is: {average}");

//         // Step 3: Find the largest number
//         int max = numbers[0];
//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 max = number;
//             }
//         }
//         Console.WriteLine($"The largest number is: {max}");
//     }
// }












using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Largest number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Smallest positive number
        int minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        // Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

