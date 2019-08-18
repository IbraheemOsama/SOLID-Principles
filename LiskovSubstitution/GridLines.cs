using System;
using System.Text;

namespace liskovSubstitution
{
    public class GridLines : IDisplay
    {
        public int XLines { get; set; }
        public int YLines { get; set; }
        public int Space { get; set; }

        public void Display()
        {
            Console.WriteLine($"XLines :{XLines} , YLines {YLines} and Space {Space}");
        }
    }
}