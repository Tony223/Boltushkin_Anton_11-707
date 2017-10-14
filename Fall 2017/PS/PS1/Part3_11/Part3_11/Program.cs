using System;

namespace Part3_11
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double maxNumber = number, minNumber = number;
            for (; ; )
            {
                if (number == 0)
                {
                    break;
                }

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Минимальное число = {minNumber}, максимальное число = {maxNumber}");
        }
    }
}
