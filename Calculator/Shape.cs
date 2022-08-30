using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Shape
    {
        public double Pi { get; private set; }

        public Shape()
        {
            Pi = 3.14;

        }

        public void GetCalculation(Circle circle, string question, string calculationMethod)
        {
            Console.WriteLine(question);
            var readInput = Console.ReadLine();
            var convertedInput = Convert.ToDouble(readInput);
            var calculation = 0.0;
            switch (calculationMethod)
            {
                case "circumference":
                    calculation = circle.CalculateCircumference(convertedInput);

                    break;
                case "area":
                    calculation = circle.CalculateArea(convertedInput);

                    break;
            }
            Console.WriteLine(calculation);
        }

        public void GetRectangleCalculation(Rectangle rectangle, string question,string calculationMethod)
        {
            Console.WriteLine(question);
            var calculationMethod = Console.ReadLine();
            switch (calculationMethod)
            {
                case "circumference":
                    var circumferenceLength = Console.ReadLine();
                    var lengthC = Convert.ToDouble(circumferenceLength);
                    var circumferenceWidth = Console.ReadLine();
                    var widthC = Convert.ToDouble(circumferenceWidth);
                    var circumference = rectangle.CalculateCircumference(lengthC, widthC);
                    Console.WriteLine(circumference);
                    break;
                case "area":
                    var areaLength = Console.ReadLine();
                    var lengthA = Convert.ToDouble(areaLength);
                    var areaWidth = Console.ReadLine();
                    var WidthA = Convert.ToDouble(areaWidth);
                    var area = rectangle.CalculateArea(lengthA, WidthA);
                    Console.WriteLine(area);
                    break;
            }
            break;
        }
    }
}
