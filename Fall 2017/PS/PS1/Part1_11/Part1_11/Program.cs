using System;

namespace Part1_11
{
    class Program
    {

        public static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double sideA = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double sideB = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double sideC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double semiperimeter = ((sideA + sideB + sideC) / 2);
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;
        }


        static void Main()
        {
            Console.WriteLine("Введите абсциссу первой точки");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату первой точки");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите абсциссу второй точки");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату второй точки");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите абсциссу третьей точки");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату третьей точки");
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь треугольника = {Area(x1, y1, x2, y2, x3, y3)}");

        }

    }
}
