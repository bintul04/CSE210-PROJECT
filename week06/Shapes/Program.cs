using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty list of Shape
        List<Shape> shapes = new List<Shape>();

        // Create shape instances
        Square sq = new Square("Red", 5);
        Rectangle re = new Rectangle("Blue", 4, 6);
        Circle ci = new Circle("Green", 3);

        // Add shapes to the list
        shapes.Add(sq);
        shapes.Add(re);
        shapes.Add(ci);

        // Iterate through the list and display color and area
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}
