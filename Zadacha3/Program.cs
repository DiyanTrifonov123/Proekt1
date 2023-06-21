using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ocenkiBEL = new double[13];
            double[] ocenkiProgr = new double[13];

            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                Console.Write($"Въведи оценка на ученик с номер {i + 1} по БЕЛ: ");
                ocenkiBEL[i] = double.Parse(Console.ReadLine());
                if (ocenkiBEL[i] >= 2.0 && ocenkiBEL[i] <= 6.0)
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

            SortedDictionary<int, double> avg = new SortedDictionary<int, double>();
            for (int i = 0; i < ocenkiBEL.Length; i++)
            {
                avg.Add(i + 1, (ocenkiBEL[i] + ocenkiProgr[i]) / 2.0);
            }

            var maxAvg = avg.OrderByDescending(x => x.Value).First();
            var minAvg = avg.OrderBy(x => x.Value).First();

            Console.WriteLine($"Ученик с номер {maxAvg.Key} има най-висок среден успех {maxAvg.Value}.");
            Console.WriteLine($"Ученик с номер {minAvg.Key} има най-нисък среден успех {minAvg.Value}.");
        }
    }
}
