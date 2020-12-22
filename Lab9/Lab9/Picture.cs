using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab9
{
    class Picture : IDraw
    {
        private readonly List<Shape> shapes;
        public int ShapesCount => shapes.Count;

        public Picture() { shapes = new List<Shape>(); }
        public Picture(int shapesnumber) { shapes = new List<Shape>(shapesnumber); }
        public void AddShapes(Shape shape) { shapes.Add(shape); }

        public bool DeleteShape(string name, string type, double square)
        {
            if (type.Equals("Square", StringComparison.CurrentCultureIgnoreCase))
            {
                shapes.RemoveAll(s => s is Square && s.NameOfObject == name && s.GetSquare() > square);
                return true;
            }
            if (type.Equals("Circle", StringComparison.CurrentCultureIgnoreCase))
            {
                shapes.RemoveAll(s => s is Circle && s.NameOfObject == name && s.GetSquare() > square);
                return true;
            }
            if (type.Equals("Triangle", StringComparison.CurrentCultureIgnoreCase))
            {
                shapes.RemoveAll(s => s is Triangle && s.NameOfObject == name && s.GetSquare() > square);
                return true;
            }

            return false;
        }

        public Shape this[int index] => shapes.ElementAtOrDefault(index);

        public void Draw() { foreach (var shape in shapes) shape.Draw(); }
    }
}
