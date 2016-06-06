using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators =new char[] {'.',',',':',';','(',')','[',']','\"','\'','\\','/','!','?',' '};
            List<string> input = Console.ReadLine().ToLower().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Distinct();
            input.Where(x => x.Length < 5);
            input.OrderBy(x => x);
            List<string> inpu2 = input.Where(x => x.Length < 5).OrderBy(x=>x).ToList();

            Console.WriteLine(String.Join(", ", inpu2.Distinct()));
        }
    }
}
