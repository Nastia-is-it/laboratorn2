using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Lines
    {
        public Dots Start 
        {
            get;
            set; 
        }
        public Dots End 
        {
            get;
            set; 
        }
       
        public Lines(int startX, int startY, int endX, int endY) 
        {            
            Start = new Dots(startX, startY);
            End = new Dots(endX, endY);           
        }
        public Lines(Dots tempStart, Dots tempEnd)
        {
            Start = tempStart;
            End = tempEnd;
        }
        public override string ToString()
        {            
            return "Линия от " + Start.ToString() + " до " + End.ToString();
        }
       public void SetStart(int x, int y)
       {
            Start.X = x;
            Start.Y = y;
       }

        public void SetEnd(int x, int y)
        {           
            End.X = x;
            End.Y = y;
        }
    }
}
