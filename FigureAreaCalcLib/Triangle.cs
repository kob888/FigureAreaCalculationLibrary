using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalcLib
{
    public class Triangle : IFigureArea
    {
        private double a;
        private double b;
        private double c;


        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
             

        public double Area
        {
            get
            {
                return GetArea();
            }
        }


        private double GetArea()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Сторона не может быть равна нулю, или иметь отрицательное значение");

            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        public bool isRectangularTriangle
        {
            get
            {
                if (a <= 0 || b <= 0 || c <= 0)
                    throw new ArgumentException("Сторона не может быть равна нулю, или иметь отрицательное значение");

                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) ||
                     Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) ||
                     Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
