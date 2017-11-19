using System;

namespace Part2_3
{
    class Program
    {

        public static void Calculation(double eps)
        {
            int k = 0;
            double count = 0, g = 1;

            while (Math.Abs(g) > eps)
            {
                g = Pow(-1,k) / (Pow(3,k) * (2 * k + 1));
                count += g;
                k++;
            }
            count *= (2 * Math.Sqrt(3));
            Console.WriteLine(count);
        }

        public static double Pow(double x, int k)
        {
            double a = 1;

            if (k == 0)
                return 1;
            else
            {
                for (int i = 0; i < k; i++)
                    a *= x;
                return a;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter epsilon");
            double eps = double.Parse(Console.ReadLine());

            Calculation(eps);
        }
    }
}
