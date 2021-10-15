using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,s,s1,s2;
            string num;
            Console.Write("Введите четырех значное число "); num = Console.ReadLine();
            while (num.Length != 4)
            {
                Console.WriteLine("Ввкдитк 4-хзначное число"); num = Console.ReadLine();
                continue;
            }
            s = Convert.ToInt32(num);
            d = s % 10;
            s1 = s / 10;
            c = s1 % 10;
            s1 = s1 / 10;
            b = s1 % 10;
            s1 = s1 / 10;
            a = s1 % 10;
            s2 = a * b * c * d; 
            Console.WriteLine(a + " * "  + b +  " * " + c + " * " + d + " = " + s2);
        }
    }
}
