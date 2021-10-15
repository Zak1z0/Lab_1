using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Obchee
{
    class Program
    {
        static void Main(string[] args)
        {

            double a; int D;
            string str;
            Console.WriteLine("Введите число");                         //Просим ввести число
            str= Console.ReadLine(); a = Convert.ToDouble(str);         //Вводится чило как строка и переводится в число
            a = a * 10;                                                 //Умножаем на десят чтобы достать первую цифру после запятой
            D = (int)a;                                                 //переводит из типа double в тип integer
            D = D % 10;                                                 //находим остаток от деления на 10
            Console.WriteLine("Первое число после запятой - это " + D); //выводим этот остаток и это первое число после запятой
        }
    }
}
