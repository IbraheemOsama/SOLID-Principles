using System;

namespace liskovSubstitution
{
    public class Rectangle : IExport, IDisplay
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Display()
        {
            Console.WriteLine($"Width :{Width} and Height {Height}");
        }

        public string Export()
        {
            return "Width :{Width} and Height {Height}";
        }
    }
}