using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<int> list = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
          {
                string[] random = input[i].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < random.Length; j++)
                {
                    list.Add(int.Parse(random[j]));
                }
            }
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }

        }
    }
}
