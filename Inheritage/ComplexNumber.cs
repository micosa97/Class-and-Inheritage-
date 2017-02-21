using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class ComplexNumber : TAbstactPoint
    {
       
        public double Im;

        //Constuctor
        public ComplexNumber(double _x, double _Im)
        {
            x = _x;
            Im = _Im;
        }

        public ComplexNumber()
        {
            x = 0;
            Im = 0;
        }


        //
        public override void moveXY(double _Rel, double _Im)  //?
        {
            x = _Rel;  //moving
            Im = _Im;
        }
        public override bool reciprocal()
        {
            try
            {
                double _x = (x) / (x * x + Im * Im);
                double _Im = (-Im) / (x * x + Im * Im);
                x = _x;
                Im = _Im;
                return true;
            } catch
            {
                return false;
            }

            

        }

        public override void reverse()
        {
            x = -x;
            // y = -y;  //nie jestem pewny czy o to chodzi
        

        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.x + c2.x, c1.Im + c2.Im);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.x - c2.x, c1.Im - c2.Im);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.x * c2.x - c1.Im * c2.Im, c1.Im * c2.x + c1.x * c2.Im);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            double _x = (c1.x * c2.x + c1.Im * c2.Im) / (c2.x * c2.x + c2.Im * c2.Im);
            double _Im = (c1.Im * c2.x - c1.x * c2.Im) / (c2.x * c2.x + c2.Im * c2.Im);
            
            return new ComplexNumber(_x, _Im);
        }

        public void print()
        {
            Console.WriteLine("Complex number:");
            Console.WriteLine("Re = " + x.ToString());
            Console.WriteLine("Im = " + Im.ToString());

        }


        public double getIm()
        {
            return Im;
        }
        public double getRel()
        {
            return x;
        }
    }
}
