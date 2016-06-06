using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[,] list = new string[count,2];
            int counterList = 0;
            int secCount = count;
            while (count > 0)
            {
                string input = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                for (int i = 0; i < input.Length; i++)
                {
                    byte a = (byte)input[i];
                    if (a%2 == 0)
                    {
                        score += a;
                    }
                    else if(a%2!=0)
                    {
                        score -= a;
                    }
                }
                list[counterList, 0] = input;
                list[counterList, 1] = score.ToString();
                counterList++;
                count--;
            }
            int bestValue = 0;
            string name = "";
            for (int i = 0; i < secCount; i++)
            {
                int number = int.Parse(list[i, 1]);
                if (number > bestValue)
                {
                    bestValue = number;
                    name = list[i, 0];
                }
            }
            Console.WriteLine("The winner is {0} - {1} points",name,bestValue);
        }
    }
}
