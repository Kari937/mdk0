using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[5]; //Колличество копонентов 5
            int index = 0;
            int sum = 0;
            while (index < 5)
            {
                array[index] = rnd.Next(35);// Максимальная масса одного компонента зелья равна 35 грамм
                sum = sum + array[index];
                Console.WriteLine(array[index]);
                index++;
            }
            Console.WriteLine("Сумма всех компонентов зелья: " + sum + " грамм");
        }
    }
}
