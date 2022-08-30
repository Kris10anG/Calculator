using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();
            var square = new Square();
            while (true)
            {
                Console.WriteLine($"Select a shape! You can chose between square, rectangle, circle");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "circle":
                        Console.WriteLine($"Which formula are we going to calculate?");
                        var calculationMethod = Console.ReadLine();
                        if (calculationMethod == "area")
                        {
                            circle.GetCalculation(circle, "Write in the radius", calculationMethod);
                        }
                        else
                        {
                            circle.GetCalculation(circle, "Write in the diameter", calculationMethod);

                        }


                        break;
                    case "rectangle":
                        Console.WriteLine($"Which formula are we going to calculate?");
                        var rectangleFormula = Console.ReadLine();
                        switch (rectangleFormula)
                        {
                            case "circumference":
                                var circumferenceLength = Console.ReadLine();
                                var lengthC = Convert.ToDouble(circumferenceLength);
                                var circumferenceWidth = Console.ReadLine();
                                var widthC = Convert.ToDouble(circumferenceWidth);
                              var circumference =  rectangle.CalculateCircumference(lengthC, widthC);
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
                    case "square":
                        Console.WriteLine($"Which formula are we going to calculate?");
                        var squareFormula = Console.ReadLine();
                        switch (squareFormula)
                        {
                            case "circumference":
                                var circumferenceSide = Console.ReadLine();
                                var sideC = Convert.ToDouble(circumferenceSide);
                              var circumference = square.CalculateCircumference(sideC);
                                Console.WriteLine(circumference);
                            break;
                            case "area":
                                var areaSide = Console.ReadLine();
                                var sideA = Convert.ToDouble(areaSide);
                               var area = square.CalculateArea(sideA);
                                Console.WriteLine(area);
                                break;
                        }
                        break;
                }  
            }
        }
    }
}
