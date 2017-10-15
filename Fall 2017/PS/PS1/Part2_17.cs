using System;

namespace Part2_17
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите n");
            int original = int.Parse(Console.ReadLine());
            int i = 2, maxLength = 0, a = 0;

            while (i < 11)
            {
                int n = original, length = 1, res1 = i, res2 = 0;

                while (n/i != 0)
                {
                    res2 = n % i;

                    if (res2 <= res1)
                    {
                        res1 = res2;
                        n /= i;
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (n <= res1 && maxLength <= length && n / i == 0)
                {
                    maxLength = length;
                    a = i;
                    Console.WriteLine($"Длина самой длинной неубывающая цепочки цифр = {maxLength}, в {a}-ичной системе счисления.");
                }
                else
                {
                    a = i;
                    Console.WriteLine($"Такой цепочки в {a}-ичной системе счисления нет или она недостаточно длинная.");
                }
                  
                i++;
            }
        }
    }
}
