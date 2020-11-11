using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int eda = 10 * 40 * 2;
                int vin = 100 * 2;
                int los = 50 * 8;
                int s = eda - vin + los;
                {
                    if (s > 500)
                        Console.WriteLine("Профессор Фарнсфорт не отплатит, так как расход составляет " + s + " $");
                }
                Console.ReadKey();
            }
        }
    }
}

