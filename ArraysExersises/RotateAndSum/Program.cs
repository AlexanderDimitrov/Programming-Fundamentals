using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] temp = new int[arr.Length];
            int[] sum = new int[arr.Length];
            int k = int.Parse(Console.ReadLine());
            int arrAlarm = 0;
            while (k > 0)
            {
                int counter = 1;
                int[] arr1= new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arrAlarm !=0)
                    {
                        arr = temp;
                    }
                    if (counter == arr1.Length)
                    {
                        counter = 0;
                    }
                    arr1[counter] = arr[i];
                    counter++;
                    if (arrAlarm != 0)
                    {
                        arrAlarm = 0;
                    }
                    
                }
                arrAlarm++;
                temp = arr1;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum[i] += arr1[i];
                }
                k--;
            }
            foreach (var VARIABLE in sum)
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }
}
