using System;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ящиков: ");
            int box = Convert.ToInt32(Console.ReadLine());
            int cont;
            int car;
            int b = 1;
            int c = 1;
            if (box % 27 == 0)
            {
                cont = box / 27;
            }
            else
            {
                cont = box / 27 + 1;
            }

            if (cont % 12 == 0)
            {
                car = cont / 12 + 1;
            }
            else
            {
                car = cont / 12 + 1;
            }

            for (int i = 1; i <= car; i++)
            {
                Console.WriteLine("\tГрузовик: " + i);
                int j = 0;
                while (j < 12 && c <= cont)
                {
                    Console.WriteLine("\tКонтейнер: " + c);
                    int k = 0;
                    while (k < 27 && b <= box)
                    {
                        Console.WriteLine("\tЯщик: " + b);
                        k++;
                        b++;
                    }
                    j++;
                    c++;
                }
                Console.ReadKey();
            }
        }
    }
}
    
