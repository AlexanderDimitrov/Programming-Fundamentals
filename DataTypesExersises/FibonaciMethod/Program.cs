using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciMethod
{
    class Program
    {
        public static void FibonaciMethod(int input)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 0; i < input; i++)
            {
                c = a;
                a = b;
                b = c + b;
                

            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            FibonaciMethod(a);
        }
    }
}
