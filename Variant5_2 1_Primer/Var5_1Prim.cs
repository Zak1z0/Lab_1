using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant5_2_1_Primer
{
    class Var5_1Prim
    {
        static void Main(string[] args)
        {
            int a, b, t, k;
            double e = 2.7, y;
            Console.Write("Введите число a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число t = "); t = Convert.ToInt32(Console.ReadLine());
            k = -b * t;
            y = Math.Pow(e, k) * Math.Sin(a * t + b) - (Math.Sqrt(Math.Abs(b * t + a)));
            Console.WriteLine("y=" + y);
        }
    }
}
