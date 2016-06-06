using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int> list= new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (list.ContainsKey(input[i]))
                {
                    list[input[i]] += 1;
                }
                else
                {
                    list.Add(input[i],1);
                }
            }
            foreach (var key in list)
            {
                Console.WriteLine("{0} -> {1}",key.Key,key.Value);
            }

        }
    }
}
//8 2.5 2.5 8 2.5