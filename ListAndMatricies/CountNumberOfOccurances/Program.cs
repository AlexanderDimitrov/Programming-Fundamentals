using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> asd = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            asd.Sort();
            Dictionary<double,double> resInts = new Dictionary<double, double>();
            double counter = 1;
            for (int i = 0; i < asd.Count-1; i++)
            {
                double number = asd[i];
                if (number == asd[i + 1])
                {
                    counter++;
                }
                else
                {
                    resInts.Add(number,counter);
                    counter = 1;
                }
                if (i == asd.Count - 2)
                {
                    resInts.Add(number,counter);
                }
            }
            foreach (var i in resInts)
            {
                Console.WriteLine(i);
            }
        }
    }
}
