using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Dots
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dots(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine("Координата X: " + X);
            Console.WriteLine("Координата Y: " + Y);
        }

        public override string ToString()
        {
            return "{" + X + ", " + Y + "}";
        }
    }
}
