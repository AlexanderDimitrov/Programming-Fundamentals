using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurencesInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            string[] replacers = Console.ReadLine().Split(' ');
            List<string> result = new List<string>();
                for (int i = 0; i < replacers.Length; i++)
                {
                    string a = replacers[i];
                    for (int j = 0; j < text.Length; j++)
                    {
                        if (text[j].Contains(a))
                        {
                            text[j] = text[j].Replace(a,new string('*',a.Length));
                        }
                    }
                }
            Console.WriteLine(String.Join(" ", text));



        }
    }
}
