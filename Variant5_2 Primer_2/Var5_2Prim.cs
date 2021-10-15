using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant5_2_Primer_2
{
    class Var5_2Prim
    {
        static void Main(string[] args)
        {
            int a, b, t;  double s;   
            Console.Write("Введите число a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число t = "); t = Convert.ToInt32(Console.ReadLine());
            s = b * Math.Sin(a * Math.Pow(t, 2) * Math.Cos(2 * t)) - 1;
            Console.WriteLine("s=" + s);
        }
    }
}
