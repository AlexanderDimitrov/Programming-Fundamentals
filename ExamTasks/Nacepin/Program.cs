using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            double usPrice = double.Parse(Console.ReadLine());
            double usWeight = double.Parse(Console.ReadLine());
            double ukPrice = double.Parse(Console.ReadLine());
            double ukWeight = double.Parse(Console.ReadLine());
            double chinaPrice = double.Parse(Console.ReadLine());
            double chinaWeight = double.Parse(Console.ReadLine());
            double usPinLv = (usPrice/usWeight)/0.58;
            double ukPinLv = (ukPrice/ukWeight)/0.41;
            double chPinLV = (chinaPrice/chinaWeight)*0.27;
            if (usPinLv < ukPinLv & usPinLv < chPinLV)
            {
                double i = Math.Max(ukPinLv, chPinLV);
                Console.WriteLine("US store. {0:f2} lv/kg",usPinLv);
                Console.WriteLine("Difference {0:f2} lv/kg", i - usPinLv);


            }
            if (usPinLv > ukPinLv & ukPinLv < chPinLV)
            {
                double i = Math.Max(usPinLv, chPinLV);
                Console.WriteLine("UK store. {0:f2} lv/kg", ukPinLv);
                Console.WriteLine("Difference {0:f2} lv/kg", i - ukPinLv);


            }
            if (chPinLV < ukPinLv & usPinLv > chPinLV)
            {
                double i = Math.Max(ukPinLv, usPinLv);
                Console.WriteLine("Chinese store. {0:f2} lv/kg",chPinLV);
                Console.WriteLine("Difference {0:f2} lv/kg",i-chPinLV);

            }

        }
    }
}
