using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            int lenght1 = input1.Length;
            int lenght2 = input2.Length;
            if (lenght1 > lenght2)
            {
                int[] arr1 = new int[lenght1];
                arr1 = input1.Select(int.Parse).ToArray();
                int[] arr2 = new int[lenght1];
                int counter = 0;
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = int.Parse(input2[counter]);
                    counter++;
                    if (counter > input2.Length-1)
                    {
                        counter = 0;
                    }
                    

                }
                int[] arrOfSum =new int[lenght1];
                for (int i = 0; i < arrOfSum.Length; i++)
                {
                    arrOfSum[i] = arr1[i] + arr2[i];
                    Console.Write(arrOfSum[i] + " ");
                }             
            }
           else if (lenght1 == lenght2)
           {
                int[] arr1 = new int[lenght1];
                int[] arr2 = new int[lenght1];
               arr1 = input1.Select(int.Parse).ToArray();
               arr2 = input2.Select(int.Parse).ToArray();
               int[] sumArr = new int[arr1.Length];
               for (int i = 0; i < arr1.Length; i++)
               {
                   sumArr[i] += arr1[i] + arr2[i];
                   Console.Write(sumArr[i]+ " ");
               }
            }
            else if (lenght2 > lenght1)
            {
                int[] arr1 = new int[lenght2];
                int[] arr2 = new int[lenght2];
                arr2 = input2.Select(int.Parse).ToArray();
                int counter = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = int.Parse(input1[counter]);
                    counter++;
                    if (counter > input1.Length - 1)
                    {
                        counter = 0;
                    }


                }
                int[] arrOfSum = new int[lenght2];
                for (int i = 0; i < arrOfSum.Length; i++)
                {
                    arrOfSum[i] = arr1[i] + arr2[i];
                    Console.Write(arrOfSum[i] + " ");
                }
            }

        }
    }
}
