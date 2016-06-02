using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<double> list = input.Select(double.Parse).ToList();
            
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i + 1] == list[i])
                {
                    list[i] = list[i] + list[i + 1];
                    list.RemoveAt(i+1);
                    i = -1;
                }
            }
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
