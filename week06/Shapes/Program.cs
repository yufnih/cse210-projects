using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("Red", 3);
        Rectangle rectangle = new Rectangle("Green", 4, 6);
        Circle circle = new Circle("Blue", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(Math.Round(shape.GetArea(), 2));
        }
    }
}