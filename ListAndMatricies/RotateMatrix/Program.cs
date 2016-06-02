using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] arr = new string[rows,cols];
            string[] input = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < cols; j++)
                {
                    arr[i,j] =input[j];
                }
            }
            for (int i = 0; i < cols; i++)
            {
                for (int j = rows-1; j >= 0; j--)
                {
                    Console.Write(arr[j,i]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
