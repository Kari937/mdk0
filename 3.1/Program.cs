using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] mas = new int[10];

                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(10);

                    Console.Write(mas[i] + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
