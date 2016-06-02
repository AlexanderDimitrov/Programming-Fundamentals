using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundAwayOfZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] arrInts = new int[arr.Length];
            for (int i = 0; i < arrInts.Length; i++)
            {
             arrInts[i] = Convert.ToInt32(Math.Round(arr[i],MidpointRounding.AwayFromZero));
            Console.WriteLine("{0} => {1}",arr[i],arrInts[i]);
            }
        }
    }
}
