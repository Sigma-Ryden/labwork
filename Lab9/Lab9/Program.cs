using System;

namespace Lab9
{
    class MainFile
    {
        static void Main()
        {
            Picture picture = new Picture();

            picture.AddShapes(new Triangle("ABC"));
            picture.AddShapes(new Triangle("MKL", 5, 3));

            picture.AddShapes(new Square("ABCD", 10, 10));

            picture.AddShapes(new Circle("O1"));
            picture.AddShapes(new Circle("O2", 2));
            picture.AddShapes(new Circle("O3", 5, 2));

            picture.Draw();

            Console.ReadKey();
        }
    }
}