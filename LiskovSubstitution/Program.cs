using System;
using System.Collections.Generic;

namespace liskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>();

            shapes.Add(new Rectangle { Width = 10, Height = 20 });
            shapes.Add(new GridLines { XLines = 20, YLines = 30, Space = 5 });

            foreach (var shape in shapes)
            {
                shape.Display();
            }

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Export());
            }
        }
    }
}
