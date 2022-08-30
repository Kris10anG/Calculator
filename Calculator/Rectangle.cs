using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Rectangle : Shape
    {
        public double CalculateCircumference(double length, double width)
        {
            var Circumference = length + length + width + width;
            return Circumference;
        }

        public double CalculateArea(double length, double width)
        {
            var Area = length * width;
            return Area;

        }
    }
}
