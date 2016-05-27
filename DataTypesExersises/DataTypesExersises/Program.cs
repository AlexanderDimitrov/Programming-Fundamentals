using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExersises
{
    class Program
    {
        public static int GetMax(int a ,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[3];
            a[0] = int.Parse(Console.ReadLine());
            a[1] = int.Parse(Console.ReadLine());
            a[2] = int.Parse(Console.ReadLine());
            int bestNum = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                int c = GetMax(a[i], a[i + 1]);
                if (bestNum < c)
                {
                    bestNum = c;
                }
            }
            Console.WriteLine(bestNum);
        }
    }
}
//Software University
//B
//y
//e
//I love programming
