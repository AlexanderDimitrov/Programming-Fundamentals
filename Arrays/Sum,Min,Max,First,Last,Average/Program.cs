using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_First_Last_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int lenght = arr.Length - 1;
            Console.WriteLine("Sum = {0}",sum);
            Console.WriteLine("Min = {0}",arr.Min());
            Console.WriteLine("Max = {0}",arr.Max());
            Console.WriteLine("First = {0}",arr[0]);
            Console.WriteLine("Last = {0}",arr[lenght]);
            Console.WriteLine("Avarage ={0}",sum/a);
        }
    }
}
