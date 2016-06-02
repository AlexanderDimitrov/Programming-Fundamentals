using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                int a = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    int b = arr[j];
                    sum = a + b;
                    for (int k = 0; k < arr.Length; k++)
                    {
                        int c = arr[k];
                    if (sum.Equals(c))
                        {
                            Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                            counter++;
                        }

                    }
                  
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
