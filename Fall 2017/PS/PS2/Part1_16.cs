using System;

namespace Part1_16
{
    class Program
    {        
        public static void Calculation(double eps)
        {
            int n = 0;
            double g = 1, count = 0;

            while (Math.Abs(g) >= eps)
            {
                if (n % 2 == 0)
                    g = 1.0 / ((2 * n + 1) * (2 * n + 1));
                else
                    g = -1.0 / ((2 * n + 1) * (2 * n + 1));
                n++;
                count += g;
            }
            Console.WriteLine($"Number of steps = {n}");
            Console.WriteLine($"G = {count}");
        }

        static void Main()
        {
            Console.WriteLine("Enter the epsilon");
            double eps = double.Parse(Console.ReadLine());
            Calculation(eps);
        }
    } 
}
