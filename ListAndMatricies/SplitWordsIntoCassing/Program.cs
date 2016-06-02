using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SplitWordsIntoCassing
{
    class Program
    {
        public static bool IsLowerCase(char a)
        {
            if (Char.IsLower(a))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] separator = new string[] {",",";",":"," ",".","!","(",")","\"","\"","\'", "\\", "/","[","]"};
            string[] input = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            int flagLower = 0;
            int flagUpper = 0;
            int flagMixed = 0;
            for (int i = 0; i < input.Length; i++)
            {
                flagLower = 0;
                flagUpper = 0;
                string word = input[i];
                if (Char.IsDigit(word[0]))
                {
                    mixedCase.Add(word);
                }
                for (int j = 0; j < word.Length - 1; j++)
                {
                    if (IsLowerCase(word[j]) | IsLowerCase(word[j+1]))
                    {
                        flagLower++;
                    }
                    if (!IsLowerCase(word[j]) | !IsLowerCase(word[j+1]))
                    {
                        flagUpper++;
                    }
                    if (flagLower>0 && flagUpper > 0)
                    {
                        mixedCase.Add(word);
                        break;
                    }
                    else if (flagLower > 0)
                    {
                        lowerCase.Add(word);
                        break;
                    }
                    else if (flagUpper > 0)
                    {
                        upperCase.Add(word);
                        break;
                    }
                }
            }
            Console.Write("Lower Case : ");
            foreach (var VARIABLE in lowerCase)
            {
                Console.Write(VARIABLE + ", ");
            }
            Console.WriteLine();
            Console.Write("Mixed Case : ");
            foreach (var VARIABLE in mixedCase)
            {
                Console.Write(VARIABLE + ", ");
            }
            Console.WriteLine();
            Console.Write("Upper Case : ");
            foreach (var VARIABLE in upperCase)
            {
                Console.Write(VARIABLE + ", ");
            }
            Console.WriteLine();
        }
    }
}
