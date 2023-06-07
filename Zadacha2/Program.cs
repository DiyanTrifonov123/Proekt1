using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ocenkiBEL = new int[13];
            int[] ocenkiProgr = new int[13];

            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                Console.Write($"Въведи оценка на ученик с номер {i+1} по БЕЛ: ");                
                ocenkiBEL[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < ocenkiProgr.Length; i++)
            {
                Console.Write($"Въведи оценка на ученик с номер {i + 1} по програмиране: ");
                ocenkiProgr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                if (ocenkiBEL[i] < ocenkiProgr[i])
                {
                    Console.WriteLine($"Номер: {i+1} Оценка БЕЛ: {ocenkiBEL[i]} Оценка програмиране: {ocenkiProgr[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
