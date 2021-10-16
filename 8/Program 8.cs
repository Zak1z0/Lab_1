using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,s;
            string str;
            Console.Write("Введите x: "); str = Console.ReadLine(); x = Convert.ToInt32(str);
            if (x <= 0)
            {
                while (x <= 0)
                {
                    Console.Write("x не может быть меньше или равен 0 " + "Введите снова: ");
                    str = Console.ReadLine(); x = Convert.ToInt32(str);

                }
            }
            else 
            {
                s = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            }
            s = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine("Ответ: " + s);
        }
    }
}
