using System;

namespace Lab9
{
    class Square : Shape
    {
        public override ConsoleColor Color { get; set; }
        public override int NumberVertex => 4;
        public override string NameOfObject { get; }
        public int SideLenght { get; set; }

        public Square(string shapename)
        {
            Random random = new Random();
            NameOfObject = shapename;
            Color = (ConsoleColor)random.Next(32);
            SideLenght = random.Next(10);
        }

        public Square(string shapename, int sideLenght)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)new Random().Next(32);
            SideLenght = sideLenght;
        }

        public Square(string shapename, int sideLenght, int color)
        {
            NameOfObject = shapename;
            Color = (ConsoleColor)color;
            SideLenght = sideLenght;
        }
        public override double GetPerimeter() => SideLenght * 4;
        public override double GetSquare() => (SideLenght) ^ 2;

        public override void Draw()
        {
            Console.WriteLine("\nYour figure: Square ");
            Console.WriteLine($"Name: {NameOfObject}");
            Console.WriteLine($"Number of vertices: {NumberVertex}");
            Console.WriteLine($"Lenght of side: {SideLenght}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Square: {GetSquare()}");

            Console.ResetColor();
        }
    }
}