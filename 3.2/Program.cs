using System;

namespace _3._2
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
                    //Console.Write(mas[i] + " ");
                    Console.Write(mas[i] + 10 + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
