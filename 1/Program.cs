using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму");
            int S = Convert.ToInt32(Console.ReadLine());
            if (S < 40)
            {
                Console.WriteLine("Не хватает средств, доплатите!");
            }
            else if ((S >= 40) && (S < 60))
            {
                Console.WriteLine("Вы можете купить воду");
            }
            else if ((S >= 60) && (S < 100))
            {
                Console.WriteLine("Вы можете купить воду или чай");
            }
            else if (S >= 100)
            {
                Console.WriteLine("Вы можете купить воду или чай или кофе");
            }
            Console.ReadKey();
        }
    }
}
        
