using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCredit
{
    class Program
    {
        static int kredit(int platej, int summa)
        {
           return summa - platej;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для банка");
            int summa = 700;
            Console.WriteLine("Ваш долг 700 рублей. Какую суммы Вы вносите:");
            int platej = int.Parse(Console.ReadLine());
            int ostatok = kredit(platej, summa);
            if (ostatok < 0)
            {
                Console.WriteLine("У Вас переплата {0} рублей", ostatok);
            }
            else if (ostatok > 0)
            {
                Console.WriteLine("Вам осталось погасить {0} рублей", ostatok);
            }
            else 
                {
                Console.WriteLine("Поздравляем! Вы погасили долг.");
                }

            //Delay
            Console.ReadKey();
        }
    }
}
