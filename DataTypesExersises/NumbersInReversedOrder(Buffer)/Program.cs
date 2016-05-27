using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder_Buffer_
{
    class Program
    {
        public static void Reverser(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Reverser(input);
        }
    }
}
