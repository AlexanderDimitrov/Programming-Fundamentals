using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());
            int portions = 0;
            double onePortionPrice =(2*bananaPrice) +(4*eggPrice)+(0.2*berriesPrice) ;
            if (guests%6 != 0)
            {
                portions = guests/6 + 1;
            }
            else
            {
                portions = guests/6;
            }
            double result = 0;
            result = cash - portions*onePortionPrice;
            if (result < 0)
            {
                
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", -result);
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",portions*onePortionPrice);
            }
        }
    }
}
