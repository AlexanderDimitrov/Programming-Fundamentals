using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int bestNumber = 0;
            int bestCounter = 0;            
            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                int random = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (random.Equals(arr[j]))
                    {
                        counter++;
                    }
                }
                if (bestCounter < counter)
                {
                    bestCounter = counter;
                    bestNumber = random;
                }

            }
            Console.WriteLine(bestNumber);
        }
    }
}
