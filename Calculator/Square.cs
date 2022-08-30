using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Square : Shape
    {
        public double CalculateCircumference(double side)
        {
            var circumference = side + side + side + side;
            return circumference;
        }

        public double CalculateArea(double side)
        {
            var Area = side * side;
            return Area;
        }
    }
}
