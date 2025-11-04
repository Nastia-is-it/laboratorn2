using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Lines
    {
        public Dots Start { get; set; }
        public Dots End { get; set; }

        public Lines(Dots start, Dots end)
        {
            Start = start;
            End = end;
        }

        public Lines(int startX, int startY, int endX, int endY)
        {
            Start = new Dots(startX, startY);
            End = new Dots(endX, endY);
        }

        public override string ToString()
        {            
            return "Линия от " + Start.ToString() + " до " + End.ToString();
        }
       
    }
}
