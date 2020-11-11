using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние между рядами: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние между дырочками в ряду: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество дырочек на ряд: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина свободного конца шнурка: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int length = (d * 2 + (c - 1) * 2 * (a + b) + a);
            Console.WriteLine("Длина шнурка вашего ботинка: " + length + " см");
            Console.ReadKey();
        }
    }
}
