using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAReciet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Console.WriteLine("{0}{1}{2}", new string('/', 1), new string('-', 22), new string('\\', 1));
            //List
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("{0} {1,20:f2} {0}", new string('|', 1), numbers[i]);
            }
            Console.WriteLine("{0}{1}{2}", new string('|', 1), new string('-', 22), new string('|', 1));
            //Total
            Console.WriteLine("{0} Total: {1,13:f2} {0}", new string('|', 1), numbers.Sum());
            Console.WriteLine("{0}{1}{2}", new string('\\', 1), new string('-', 22), new string('/', 1));

        }
    }
}
