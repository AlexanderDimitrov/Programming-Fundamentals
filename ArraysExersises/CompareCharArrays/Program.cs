using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        public static bool IsEqualChar(char a, char b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int smallerArray = Math.Min(first.Length, second.Length);
            bool areEqual = false;
            for (int i = 0; i < smallerArray; i++)
            {
                if (first[i] == second[i])
                {
                    continue;
                }
                if (first[i] < second[i])
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }
                areEqual = true;
                break;
            }
            if (!areEqual)
            {
                if (first.Length <= second.Length)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }
            }
        }
    }
}
