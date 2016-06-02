using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrDays = new string[7];
            arrDays[0] = "Mondey";
            arrDays[1] = "Tuesday";
            arrDays[2] = "Wednesday";
            arrDays[3] = "Thursday";
            arrDays[4] = "Friday";
            arrDays[5] = "Saturday";
            arrDays[6] = "Sunday";
            switch (input)
            {
                case "1":
                    Console.WriteLine(arrDays[0]);
                    break;
                case "2":
                    Console.WriteLine(arrDays[1]);
                    break;
                case "3":
                    Console.WriteLine(arrDays[2]);
                    break;
                case "4":
                    Console.WriteLine(arrDays[3]);
                    break;
                case "5":
                    Console.WriteLine(arrDays[4]);
                    break;
                case "6":
                    Console.WriteLine(arrDays[5]);
                    break;
                case "7":
                    Console.WriteLine(arrDays[6]);
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }

        }
    }
}
