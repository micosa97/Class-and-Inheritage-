using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage 
{
    class TSegment
    {
        protected TPoint first, last;  //protected due to TRasterSegment

        //Constructors
        public TSegment()
        {
            first = new TPoint();
            last = new TPoint();
        }

        public TSegment(TPoint _first, TPoint _last)
        {
            first = _first;
            last = _last;
        }

        public double LE()
        {
            return Math.Sqrt((first.x - last.x) * (first.x - last.x) + (first.y - last.y) * (first.y - last.y));
        }

        public double LM()
        {
            return (Math.Abs(first.x - last.x)  + Math.Abs(first.y - last.y));
        }

        public void print ()
        {
            Console.WriteLine("  vector: \n F:");
            first.print();
            Console.WriteLine(" L:");
            last.print();
        }
    }



    
}
