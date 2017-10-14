using System;

namespace Part1_20
{
    class Program
    {

        public static string HappyTicket(int a1, int b1, int c1, int d1, int e1, int f1, int a2, int b2, int c2, int d2, int e2, int f2)
        {
            int a3 = a1 + a2;
            int b3 = b1 + b2;
            int c3 = c1 + c2;
            int d3 = d1 + d2;
            int e3 = e1 + e2;
            int f3 = f1 + f2;
            string result;

            a3 %= 10;
            b3 %= 10;
            c3 %= 10;
            d3 %= 10;
            e3 %= 10;
            f3 %= 10;

            return result = a3 + b3 + c3 != d3 + e3 + f3 ? "Несчастливый билет" : "Счастливый билет";

        }


        static void Main()
        {
            Console.WriteLine("Введите первую цифру первого билета");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру первого билета");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью цифру первого билета");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертую цифру первого билета");
            int d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пятую цифру первого билета");
            int e1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шестую цифру первого билета");
            int f1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первую цифру второго билета");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру второго билета");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью цифру второго билета");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертую цифру второго билета");
            int d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пятую цифру второго билета");
            int e2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шестую цифру второго билета");
            int f2 = int.Parse(Console.ReadLine());

            Console.WriteLine(HappyTicket(a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2));
        }

    }
}