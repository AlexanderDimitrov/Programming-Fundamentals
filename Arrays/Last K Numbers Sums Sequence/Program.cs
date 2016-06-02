using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr=new long[n];
            arr[0] = 1;
            long sum = 0;
            int sumK = 0;
            for (int i = 1; i < n; i++)
            {
                arr[i] = SumNums(arr,i - k , i-1);
            }
            foreach (var l in arr)
            {
                Console.Write(l + " ");
            }
        }

        private static long SumNums(long[] arr,int startIndex, int endIndex)
        {
            long sum = 0;
            for (int j = startIndex; j <= endIndex; j++)
            {
                if (j >= 0)
                {
                    sum += arr[j];
                }
            }
            return sum;
        }
    }
}
