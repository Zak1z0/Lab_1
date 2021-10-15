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
            int x, s;
            string num;
            Console.Write("Введите x "); num = Console.ReadLine(); x = Convert.ToInt32(num);
            Console.WriteLine("Вычеслим 3 * x^4 – 5 * х^3 + 2 * х^2 – x + 7");
            s = 3 * x^4 - 5 * x^3 + 2 *  x^2 - x + 7;
            Console.WriteLine("Ответ равен " + s);
        }
    }
}
