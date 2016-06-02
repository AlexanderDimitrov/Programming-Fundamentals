using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (IsItRounded(list[i]))
                {
                    result.Add((int)list[i]);
                }
            }
            result.Sort();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i] + " ");
            }
        }

        private static bool IsItRounded(double d)
        {
            double result = Math.Sqrt(d);
            string result1 = result.ToString();
            if (result1.Contains("."))
            {
                return false;
            }
            return true;
        }
    }
}
