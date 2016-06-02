using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr =  input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int index = char.ToUpper(arr[i]) - 65;
                Console.WriteLine("{0} -> {1}",arr[i],index);
            }

        }
    }
}
