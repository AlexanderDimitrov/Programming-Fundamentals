using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        public static bool IsPalindrome(int value)
        {
            string valuee = value.ToString();
            int min = 0;
            int max = valuee.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = valuee[min];
                char b = valuee[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                if (IsPalindrome(i)&&IsDevisible(i)&&IsEvenable(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsEvenable(int n)
        {
            int a = 0;
            while (n != 0)
            {
                a += n%10;
                if (n%2 == 0)
                {
                    return true;
                }
                n=n/10;
            }
            return false;
        }

        private static bool IsDevisible(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum%7 == 0)
            {
               return true;
            }
            return false;
        }
    }
}
