using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]] += 1;
                }
                else
                {
                    dictionary.Add(input[i],1);
                }
            }
            List<string> result = new List<string>();
            foreach (var i in dictionary)
            {
                if (i.Value%2 != 0)
                {
                   result.Add(i.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
            
        }
    }
}
