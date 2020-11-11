using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sum = 0;
                Random rnd = new Random();
                int[] mas = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    mas[i] = rnd.Next(10, 100);
                    Console.Write(mas[i] + " ");
                    sum += mas[i];
                }
                Console.WriteLine();
                {
                    Console.WriteLine(sum);
                    Console.ReadKey();
                }
            }
        }
    }
}

