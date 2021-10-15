using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s1,s2; double u;
            string str1, str2, str3, str4,str5, str6;
            Console.Write("Введите часы "); str1 = Console.ReadLine(); h = Convert.ToInt32(str1);

            while (h < 0)
            {
                Console.WriteLine("Часы не могут быть меньше 0");
                Console.WriteLine("Введите час "); str4 = Console.ReadLine(); h = Convert.ToInt32(str4);
                while (h > 11)
                { 
                    Console.WriteLine("Часы не должны быть больше 11");
                    Console.WriteLine("Введите час "); str4 = Console.ReadLine(); h = Convert.ToInt32(str4);
                continue; 
                }
              continue;
            }
            Console.Write("Введите минуты "); str2 = Console.ReadLine(); m = Convert.ToInt32(str2);
            while (m < 0)
            {
                Console.WriteLine("Минуты не могут быть меньше 0");
                Console.WriteLine("Введите минуты "); str5 = Console.ReadLine(); m = Convert.ToInt32(str5);
                
                while (m >= 59)
                {
                    Console.WriteLine("Минуты не могут быть больше 59");
                    Console.WriteLine("Введите минуты "); str5 = Console.ReadLine(); m = Convert.ToInt32(str5);
                    continue;
                }
                continue;
            }
            Console.Write("Введите секунды "); str3 = Console.ReadLine(); s1 = Convert.ToInt32(str3);
            while (s1 < 0)
            {
                Console.WriteLine("Секунды не могут быть меньше 0");
                Console.WriteLine("Введите секунды "); str6 = Console.ReadLine(); s1 = Convert.ToInt32(str6);
                
                while (s1 >= 59)
                {
                    Console.WriteLine("Секунды не могут быть больше 59");
                    Console.WriteLine("Введите секунды "); str6 = Console.ReadLine(); s1 = Convert.ToInt32(str6);
                    continue;
                }
                continue;
            }
            s2 = h * 3600 + m * 60 + s1;
            u = 360 * s2 / 12 / 3600;
            Console.WriteLine("Угол между положением часовой стрелки в начале суток и ее положением в " + h + 
                " часов," + m + " минут и " + s1 + " секунд равна = " + u);
        }
    }
}
