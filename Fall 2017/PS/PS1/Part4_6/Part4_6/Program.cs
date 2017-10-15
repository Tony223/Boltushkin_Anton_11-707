using System;

namespace Part4_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            double a, b;
            for (int i = 1; i <= n; i++)
            {
                if (n > 10000)
                {
                    Console.WriteLine("Число больше 10000");

                    break;
                }
                double sum1 = 0;

                for (a = 1; a <= i / 2; a++)
                {
                    if (i % a == 0)
                        sum1 += a;                   
                }
                a = (a - 1) * 2;

                double sum2 = 0;

                for (b = 1; b <= sum1/2; b++)
                {
                    if (sum1 % b == 0)
                        sum2 += b;
                }
                b = (b - 1) * 2;

                if(sum1 != a && sum1 + sum2 < n && sum1 == b && sum2 == a)
                {
                    Console.WriteLine($"{sum1} и {sum2} - дружественные числа");
                }   
            }          
        }
    }
}