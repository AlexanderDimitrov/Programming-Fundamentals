using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSymLINQ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> result = new List<int>();
            int listLenght = list.Count/4-1;
            for (int i = 0; i < list.Count/4; i++)
            {
                row1.Add(list[listLenght]);
                listLenght--;
            }
          listLenght=  list.Count - 1;
            for (int i = 0; i < list.Count/4; i++)
            {
                row1.Add(list[listLenght]);
                listLenght--;
            }
            listLenght =list.Count/4;
            for (int i = 0; i < list.Count/2; i++)
            {
                row2.Add(list[listLenght]);
                listLenght++;
            }
            for (int i = 0; i < list.Count/2; i++)
            {
                int resultP = row1[i] + row2[i];
                result.Add(resultP);
            }
            Console.WriteLine(String.Join(" ",result));


        }
    }
}
