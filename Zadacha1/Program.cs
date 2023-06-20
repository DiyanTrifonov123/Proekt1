using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Въведи число (за край се счита 0): ");
            int input = int.Parse(Console.ReadLine());
            byte counter = 0;

            while (input != 0)
            {
                list.Add(input);
                Console.Write("Въведи число (за край се счита 0): ");
                input = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Брой на числата: {list.Count}");
            Console.WriteLine($"Брой на отрицателните числа: {counter}");
        }
    }
}
