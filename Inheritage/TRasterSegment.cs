using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class TRasterSegment : TSegment
    {
        
        private List<TPoint> additionPoints = new List<TPoint>();


        //Constructors are not inherited so I made them again
        public TRasterSegment()
        {
            first = new TPoint();
            last = new TPoint();
            generate();
        }

        public TRasterSegment(TPoint _first, TPoint _last)
        {
            first = _first;
            last = _last;
            generate();
        }



        public void generate()
        {
            for (int i = 0; i < 10; i++)
            {
                double x = first.x + ((last.x - first.x) / 11) * (i + 1);
                double y = first.y + ((last.y - first.y) / 11) * (i + 1);
                additionPoints.Add(new TPoint(x, y));
            }
        }

        public new void print ()  //due to inheriting print() from TSegment
        {
            Console.WriteLine("Raster Vector:");
            first.print();
            foreach (TPoint p in additionPoints)
            {
                Console.WriteLine();
                p.print();
            }
            Console.WriteLine();
            last.print();

        }


        


    }
}
