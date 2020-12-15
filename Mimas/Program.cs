using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimas
{
    class Program
    {
        static void Main(string[] args)
        {
            string z = "Мимас — спутник Сатурна, открытый 17 сентября 1789 года Уильямом Гершелем. Назван в честь Мимаса — одного из титанов греческой мифологии.";
            Console.WriteLine(z.Trim().Remove(0,1));
            Console.ReadKey();
        }
    }
}
