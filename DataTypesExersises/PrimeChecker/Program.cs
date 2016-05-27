using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Method(FindPrimesInRange(a,b));
        }

        public static bool IsPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
        public static void Method(List<int> FindPrimesInRange)
        {
            
            Console.WriteLine(String.Join(", ",FindPrimesInRange));
        }

        public static List<int> FindPrimesInRange(int input, int endNum)
        {
            List<int> list = new List<int>();
            int s = input;
            if (input == 1)
            {
                input++;
            }

            for (int i = input; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
