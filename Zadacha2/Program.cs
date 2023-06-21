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
            double[] ocenkiBEL = new double[13];
            double[] ocenkiProgr = new double[13];

            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                Console.Write($"Въведи оценка на ученик с номер {i+1} по БЕЛ: ");                
                ocenkiBEL[i] = double.Parse(Console.ReadLine());
                if (ocenkiBEL[i] >= 2.0 && ocenkiBEL[i] <=6.0)
                {
                    continue;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < ocenkiProgr.Length; i++)
            {
                Console.Write($"Въведи оценка на ученик с номер {i + 1} по програмиране: ");
                ocenkiProgr[i] = double.Parse(Console.ReadLine());
                if (ocenkiProgr[i] >= 2.0 && ocenkiProgr[i] <= 6.0)
                {
                    continue;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                if (ocenkiBEL[i] < ocenkiProgr[i])
                {
                    Console.WriteLine($"Номер: {i+1} Оценка БЕЛ: {ocenkiBEL[i]:f2} Оценка програмиране: {ocenkiProgr[i]:f2}");
                }
            }
            Console.WriteLine();
        }
    }
}
