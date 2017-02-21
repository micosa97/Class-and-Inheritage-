using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class FullComplexNumber : ComplexNumber
    {
        public FullComplexNumber(double _x, double _Im) : base(_x, _Im)

        {
            x = _x;
            Im = _Im;
        }

        public FullComplexNumber()

        {
            x = 0;
            Im = 0;
        }

        public void setFromPolarForm(double w, double alfa)  // postac tryg
        {
            x = w * Math.Cos(alfa);
            Im = w * Math.Sin(alfa);
        }
        public void setFromEurelFormula(double w, double alfa)  // postac wykladnicza
        {
            x = w * Math.Cos(alfa);
            Im = w * Math.Sin(alfa);   ///actually same as above
        }


        public void PrintPolarForm()  // postac tryg
        {
            double w = Math.Sqrt(x * x + Im * Im);
            double alfa = 0 ;
            if (x > 0) alfa = Math.Atan(Im / x);
            else
            {
                if (x < 0)
                {
                    if (Im >= 0) alfa = Math.Atan(Im / x) + Math.PI;
                    else alfa = Math.Atan(Im / x) - Math.PI;
                }
                else
                {
                    if (Im > 0) alfa = Math.PI / 2;
                    if (Im < 0) alfa = -Math.PI / 2;
                    if (Im == 0) alfa = 0;
                }
            }
            Console.WriteLine("Polar Form: " + w.ToString() + " * (cos(" + alfa.ToString() + ") + i * sin(" + alfa.ToString() + "))");
            
        }
        public void PrintEurelFormula()  // postac wykladnicza
        {
            double w = Math.Sqrt(x * x + Im * Im);
            double alfa = 0;
            if (x > 0) alfa = Math.Atan(Im / x);
            else
            {
                if (x < 0)
                {
                    if (Im >= 0) alfa = Math.Atan(Im / x) + Math.PI;
                    else alfa = Math.Atan(Im / x) - Math.PI;
                }
                else
                {
                    if (Im > 0) alfa = Math.PI / 2;
                    if (Im < 0) alfa = -Math.PI / 2;
                    if (Im == 0) alfa = 0;
                }
            }

            Console.WriteLine("Eurel Formula: " + w.ToString() + " * e ^ (i * " + alfa.ToString() + ")");
        }


    }
}
