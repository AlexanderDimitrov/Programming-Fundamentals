using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int[] condensed = new int[arr.Length];
            int[] temp = new int[condensed.Length];
            int counter = 0;
            while (condensed.Length != 1)
            {
                condensed = new int[condensed.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    if (counter != 0)
                    {
                        arr = temp;
                    }
                    condensed[i] = arr[i] + arr[i + 1];
                    if (counter > 0)
                    {
                        counter = 0;
                    }
                }
                temp = condensed;
                counter++;

            }
            if (arr[0] == 1)
            {
                condensed[0] = 1;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}

