using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDecimalInc
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            List<decimal> list = arr.ToList();
            list.Sort();
            foreach (var VARIABLE in list)
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }
}
