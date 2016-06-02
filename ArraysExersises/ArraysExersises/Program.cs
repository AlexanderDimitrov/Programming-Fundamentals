using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExersises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] input1 = Console.ReadLine().Split(' ');
            int length = input.Length-1;
            int length1 = input1.Length-1;
            int counter = 0;
            int secArrCounter = 0;
            if (length > length1)
            {
                secArrCounter = length;
                for (int i = 0; i < input1.Length; i++)
                {
                    
                    if (input[i].Equals(input1[i]))
                    {
                        counter++;
                    }
                }
                
                for (int i = input1.Length -1; i >= 0; i--)
                {
                    if (input[secArrCounter].Equals(input1[i]))
                    {
                        counter++;
                    }
                    secArrCounter --;
                }
            }
            if (length < length1)
            {
                secArrCounter = length1;
                for (int i = 0; i < input.Length; i++)
                {

                    if (input[i].Equals(input1[i]))
                    {
                        counter++;
                    }
                }

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i].Equals(input1[secArrCounter]))
                    {
                        counter++;
                    }
                    secArrCounter--;
                }
            }
            if (length == length1)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Equals(input1[i]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
