using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    abstract class TAbstactPoint
    {
        protected double x;
        public abstract void moveXY(double _x, double _y);
        public abstract bool reciprocal();
        public virtual void reverse()
        {
            x = -x; 
        }
    }
}
