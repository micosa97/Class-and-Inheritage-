using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class TPoint : TAbstactPoint
    {
        public new double x; //it's required due to calc length of vector
        public double y;

        //Constuctors
        public TPoint()
        {
            x = 0;
            y = 0;
        }
        public TPoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        //
        public override void moveXY(double _x, double _y)
        {
            x = _x;  //moving
            y = _y;
        }
        public override bool reciprocal()
        {
            if (x == 0) return false;
            x = 1 / x;
            //x = 1 / x; //?? 
            return true;
        }

        public override void reverse ()
        {
            x = -x;
           // y = -y;  //nie jestem pewny czy o to chodzi

        }

        //extra
        public void print ()
        {
            Console.WriteLine("x = " + x.ToString());
            Console.WriteLine("y = " + y.ToString());
        }



    }
}
