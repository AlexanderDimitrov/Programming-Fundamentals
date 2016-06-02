using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExractMiddleElemetns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLength = arr.Length;
            if (arrLength == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else if (arrLength%2 == 0)
            {
               arrLength=  arrLength/2;
                Console.WriteLine(arr[arrLength-1].ToString() + ","+" " + arr[arrLength].ToString());
            }
            else if (arrLength%2 != 0)
            {
                arrLength = arrLength / 2;
                Console.WriteLine(arr[arrLength - 1].ToString() + "," + " " + arr[arrLength].ToString() + "," + " " + arr[arrLength+1]);
            }
            
        }
    }
}
