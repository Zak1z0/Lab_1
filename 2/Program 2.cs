using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  hour, min, sec;
            string str;
            Console.Write("Введите секунды ");
            str = Console.ReadLine(); sec = Convert.ToInt32(str);
            while (sec < 0)
            {
                Console.WriteLine("Секунды не должи быть меньше 0" + " Введите еще раз");
                str = Console.ReadLine(); sec = Convert.ToInt32(str);
                continue;
            }
            hour = sec / 3600;
            min = (sec - (hour * 3600)) / 60 ;
            Console.WriteLine("Прошло "+ hour + " часов");
            Console.WriteLine("Прошло " + min + " Минут"); 
        }
    }
}
