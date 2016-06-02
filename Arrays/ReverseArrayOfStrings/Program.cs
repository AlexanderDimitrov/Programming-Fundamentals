using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string temp;
            int lenght = input.Length - 1;
            for (int i = 0; i < input.Length/2; i++)
            {
                temp = input[i];
                input[i] = input[lenght];
                input[lenght] = temp;
                lenght--;
            }
            foreach (var s in input)
            {
                Console.Write(s + " ");
            }
        }
    }
}
