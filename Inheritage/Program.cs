using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritage
{
    class Program
    {
        static void Main(string[] args)
        {
            TPoint point = new TPoint(3, 2);
            point.print();
            point.reciprocal();
            point.print();
            point.reverse();
            point.print();

            //

            TSegment segment = new TSegment(new TPoint(1, 5), new TPoint(5, 2));
            segment.print();
            Console.WriteLine(segment.LE());
            Console.WriteLine(segment.LM());
            
            
            //


            TRasterSegment Rsegment = new TRasterSegment(new TPoint(1, 1), new TPoint(12, 23));
            Rsegment.print();

            //

            ComplexNumber c1 = new ComplexNumber(1, 1);
            c1.print();
            c1.reciprocal();
            c1.print();
            c1.reciprocal();
            c1.print();

            c1.moveXY(1, 2);

            Console.WriteLine(c1.getRel().ToString());
            Console.WriteLine(c1.getIm().ToString());



            ComplexNumber c2 = new ComplexNumber(2, 2);

            ComplexNumber c3 = c1 + c2;
            c3.print();

            c3 = c1 - c2;
            c3.print();

            c3 = c1 * c2;
            c3.print();

            c3 = c1 / c2;
            c3.print();

            FullComplexNumber fc = new FullComplexNumber();

            fc.setFromPolarForm(12, -1);
            fc.PrintPolarForm();

            fc.moveXY(-1, 10);
            fc.PrintEurelFormula();

           
            


            Console.ReadLine();



        }
    }
}
