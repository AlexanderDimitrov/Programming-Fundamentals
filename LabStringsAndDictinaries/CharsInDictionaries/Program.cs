using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsInDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int[] counts = new int[input.Max()+1];
            foreach (var ch in input)
            {
                counts[ch]++;
            }
            for(char ch = (char)0;ch<counts.Length;ch++)
                if (counts[ch] != 0)
                {
                    Console.WriteLine($"{ ch} -> { counts[ch]}");
                }
        }
    }
}
