using System;

namespace Lab9
{
    abstract class Shape
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract int NumberVertex { get; }
        public abstract string NameOfObject { get; }
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public abstract void Draw();
    }
}