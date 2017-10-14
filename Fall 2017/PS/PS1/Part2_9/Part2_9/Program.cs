using System;

namespace Part2_9
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            int lenght = binaryNumber.Length;
            int residue, count = 0;

            for (int i = 0; i < lenght; i++)
            {
                residue = number % 2;
                number = number / 2;
                count = residue + count;

            }
            Console.WriteLine($"Число единиц = {count}, двоичная запись = {binaryNumber}");
        }
    }
}
