using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Пуффендуй
                //Гриффиндор
                //Когтевран
                //Слизерин
                int[] mass = new int[4];
                Random rnd = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(1, 100);
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
                int max = mass.Max();
                int min = mass.Min();
                Console.WriteLine(max);
                Console.WriteLine(min);
                Console.ReadKey(); 
            }
        }
    }
}