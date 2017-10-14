using System;

namespace Part4_5
{
    class Program
    {
        static void Main()
        {
            int max = 1000000, count = 0;

            for (int i = 0; i < max; i++)
            {
                int sum = 0;
                if (i < 2)
                    i = 1;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (i == sum)
                {
                    count += 1;
                    Console.WriteLine($"{i} - совершенное число");
                }
            }
            Console.WriteLine($"Количество совершенных чисел = {count}");
        }
    }
}
