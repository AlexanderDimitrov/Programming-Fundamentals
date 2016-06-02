using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndMatricies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() ;
            List<int> list =new List<int>();
            List<int> list1 =new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            list1 = list.Where(x => x >= 0).ToList();
            list1.Reverse();
            if (list1.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var i in list1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
