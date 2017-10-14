using System;

namespace Part3_10
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            double previousNumber = 0;
            
            for(; ;)
            {
                double number = double.Parse(Console.ReadLine());
                number = number / 1000000000;
                
                if (number == 0)
                {
                    break;
                }
                else
                {
                    if ((number > 0 && previousNumber >= 0) || (number < 0 && previousNumber <= 0))
                    {
                        previousNumber = number;
                    }
                    else
                    {
                        previousNumber = number;
                        sum = sum + 1;                                            
                    }
                }
            }

            Console.WriteLine($"Был введен 0. Знак сменился {sum} раз");
        }
    }
}
