using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        Square sOne = new Square("red",5);
        string color = sOne.GetColor();
        Console.WriteLine(color);
        double area = sOne.GetArea();
        Console.WriteLine(area);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Blue",3,5));
        shapes.Add(new Square("Green", 3));
        shapes.Add(new Circle("Orange",40));

        foreach(Shape shape in shapes)
        {
            string color1 = shape.GetColor();
            double area1 = shape.GetArea();

            Console.WriteLine($"Color {color1}");
            Console.WriteLine($"Area: {area1}");
        }
    }
}