using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minIndex = 0;
            int maxIndex = 0;
            int temp = 0;
            int[] bestLength = new int[3];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]!=arr[i-1])
                {
                    minIndex=i;
                }
                if (arr[i] == arr[i - 1])
                {
                    maxIndex = i;
                    temp =maxIndex-minIndex;
                    if (bestLength[0] < temp)
                    {
                        bestLength[0] = temp;
                        bestLength[1] = minIndex;
                        bestLength[2] = maxIndex;
                    }
                }
               
            }
            for (int i = bestLength[1]; i <= bestLength[2]; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
