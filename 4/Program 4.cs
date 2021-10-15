using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string str1, str2;
            Console.Write("Введите число a "); str1 = Console.ReadLine(); a = Convert.ToInt32(str1);
            Console.Write("Введите число b "); str2 = Console.ReadLine(); b = Convert.ToInt32(str2);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
