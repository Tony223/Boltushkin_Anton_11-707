using System;

namespace Part2_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int residue, count = 0;


            while(number > 0)
            {
                residue = number % 2;
                number = number / 2;
                count = residue + count;

            }
            Console.WriteLine($"Число единиц = {count}");
        }
    }
}
