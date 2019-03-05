using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalcLib
{
    public class Circle : IFigureArea
    {
        private double r;

        public Circle(double radius)
        {
            r = radius;
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
            if (r <= 0)
                throw new ArgumentException("Радиус не может быть равен нулю, или иметь отрицательное значение");

            return Math.PI * Math.Pow(r, 2);
        }
    }
}
