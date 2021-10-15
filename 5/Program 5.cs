using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, S, P;
            string AB, AC;
            Console.Write("Введите длину катета AB "); AB = Console.ReadLine(); a = Convert.ToSingle(AB);
            while (a <= 0)
            {
                Console.WriteLine("Ни один из катетов не может быть меньше или равен 0");
                Console.Write("Введите AB "); AB = Console.ReadLine(); a = Convert.ToSingle(AB);
                continue;
            }
            Console.Write("Введите длину катета AC "); AC = Console.ReadLine(); b = Convert.ToSingle(AC);
            while(b <= 0)
            {
                Console.WriteLine("Ни один из катетов не может быть меньше или равен 0");
                Console.Write("Введите AC "); AC = Console.ReadLine(); b = Convert.ToSingle(AC);
                continue;
            }
            Console.WriteLine("Найдем гипотенузу: BC = √(AB^2 + AC^2)");
            Console.WriteLine(" ");
            c = (float)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(" ");
            Console.WriteLine("Длина гипотенузы BC = " + c);
            Console.WriteLine(" ");
            Console.WriteLine("Найдем периметр треугольника: P = AB+AC+BC");
            Console.WriteLine(" ");
            P = a + b + c;
            Console.WriteLine("Периметр прямоугольного треугольника равен = " + P);
            Console.WriteLine(" ");
            Console.WriteLine("Найдем площадь треугольника: S = (AB*AC)/2");
            Console.WriteLine(" ");
            S = (a * b) / 2;
            Console.WriteLine("Площаль прямоугольного треугольника равна = " + S);
        }
    }
}
