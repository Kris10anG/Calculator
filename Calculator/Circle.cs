using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Circle : Shape
    {
        

        public double CalculateCircumference(double diameter)
        {
            //Pi = 3.14;
            var circumference = Pi * diameter;
            return circumference;
        }

        public double CalculateArea(double radius)
        {
            var area = Pi * radius * radius;
            return area;
        }

        
    }
}
