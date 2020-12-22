using System;

namespace Lab9
{
    class Triangle : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex => 3;
        public override string NameOfObject { get; }
        public int side { get; set; }
        public int baseSide { get; set; }

        public Triangle(string shapename)
        {
            Random random = new Random();
            NameOfObject = shapename;
            Color = (ConsoleColor)random.Next(32);
            side = random.Next(10);
            baseSide = random.Next(side * 2);
        }

        public Triangle(string shapename, int t_side, int t_baseSide)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(32);
            side = t_side;
            baseSide = t_baseSide;
        }

        public Triangle(string shapename, int t_side, int t_baseSide, int color)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)color;
            side = t_side;
            baseSide = t_baseSide;
        }

        public override double GetPerimeter() => 2 * side + baseSide;

        public override double GetSquare() => side * Math.Sqrt(side ^ 2 - (baseSide / 2) ^ 2) / 2;

        public override void Draw()
        {
            Console.WriteLine("\nYour figure: Triangle ");
            Console.WriteLine($"Name: {NameOfObject}");
            Console.WriteLine($"Number of vertices: {NumberVertex}");
            Console.WriteLine($"Base: {baseSide}");
            Console.WriteLine($"Side: {side}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Square: {GetSquare()}");

            Console.ResetColor();
        }
    }
}