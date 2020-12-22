using System;

namespace Lab9
{
    class Circle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex => 0;
        public override string NameOfObject { get; }
        public int radius { get; set; }

        public Circle(string shapename)
        {
            Random random = new Random();
            Color = (ConsoleColor)random.Next(32);
            NameOfObject = shapename;
            radius = random.Next(10);
        }

        public Circle(string shapename, int size)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(32);
            radius = size;
        }

        public Circle(string shapename, int size, int color)
        {
            NameOfObject = shapename;
            radius = size;
            Color = (ConsoleColor)color;
        }

        public override double GetPerimeter() => Math.PI * (radius * radius);
        public override double GetSquare() => 2 * Math.PI * radius;

        public override void Draw()
        {
            Console.WriteLine($"\nYour figure: Circle ");
            Console.WriteLine($"Name: {NameOfObject}");
            Console.WriteLine($"Number of vertices: {NumberVertex}");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Square: {GetSquare()}");
        
            Console.ResetColor();
        }
    }
}