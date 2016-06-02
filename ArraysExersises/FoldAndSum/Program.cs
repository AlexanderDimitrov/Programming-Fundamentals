using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int quarterLength = arr.Length/4;
            int arrLength = arr.Length - 1;
            int qLength = arrLength-quarterLength;
            int[] temp = new int[arr.Length/2];
            int[] temp1 = new int[arr.Length/2];
            int tempCounter = temp.Length-1;
            int tempL = (temp.Length/2)-1;
            for (int i = 0; i < quarterLength; i++)
            {
                temp[tempL] = arr[i];
                tempL--;
            }
            tempL = arrLength - quarterLength+1;
            for (int i = arrLength; i >= quarterLength*3; i--)
            {
                temp[tempCounter]  = arr[tempL];
                tempCounter--;
                tempL++;
            }
            int counter = quarterLength;
            for (int i = 0; i < quarterLength; i++)
            {
                temp1[i] = arr[counter];
                counter++;
            }
            tempCounter = temp1.Length-1;
            for (int i = arrLength; i >=quarterLength*3; i--)
            {
                temp1[tempCounter] = arr[qLength];
                tempCounter--;
                qLength--;
            }
            int[] sum = new int[temp.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = temp[i] + temp1[i];
                Console.Write(sum[i] + " ");
            }

        }
    }
}
