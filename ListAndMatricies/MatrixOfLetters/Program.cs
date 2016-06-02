using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] arr = new char[rows,cols];
            char a = 'A';
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    arr[i, j] = a;
                    Console.Write(arr[i,j] + " ");
                    a++;
                }
                Console.WriteLine();
            }
            
            
                

        }
    }
}
