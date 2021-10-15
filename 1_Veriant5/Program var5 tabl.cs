using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Veriant5
{
    class Program
    {
        public static void Main(string[] args)
        {
            string show1, show2, show3, leader1, leader2, leader3; int rating1, rating2, rating3; char type1, type2, type3;
            Console.Write("Введите передачю :");show1 = Console.ReadLine();
            Console.Write("Введите ведущего этой передачи :");leader1 = Console.ReadLine();
            Console.Write("Введите рейтинг передачи :");rating1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип передачи (И - игровая, А - аналитическая, Т – ток-шоу):");type1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите передачю :"); show2 = Console.ReadLine();
            Console.Write("Введите ведущего этой передачи :"); leader2 = Console.ReadLine();
            Console.Write("Введите рейтинг передачи :"); rating2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип передачи (И - игровая, А - аналитическая, Т – ток-шоу):"); type2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите передачю :"); show3 = Console.ReadLine();
            Console.Write("Введите ведущего этой передачи :"); leader3 = Console.ReadLine();
            Console.Write("Введите рейтинг передачи :"); rating3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип передачи (И - игровая, А - аналитическая, Т – ток-шоу):"); type3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|Телепередача                                     |");
            Console.WriteLine("|_________________________________________________|");
            Console.WriteLine("|Передача          |Ведущий      |Рейтинг  |Тип   |");
            Console.WriteLine("|__________________|_____________|_________|______|");
            Console.WriteLine("|" + show1 + "         |" + leader1 + "   |" + rating1 + "        |" + type1 + "     |");
            Console.WriteLine("|__________________|_____________|_________|______|");
            Console.WriteLine("|" + show2 + "  |" + leader2 + "  |" + rating2 + "        |" + type2 + "     |");
            Console.WriteLine("|__________________|_____________|_________|______|");
            Console.WriteLine("|" + show3 + "     |" + leader3 + "   |" + rating3 + "        |" + type3 + "     |");
            Console.WriteLine("|__________________|_____________|_________|______|");
            Console.WriteLine("|Перечисляемый тип: И - игровая;                  |");
            Console.WriteLine("|                   А - аналитическая;            |");
            Console.WriteLine("|                   Т - ток-шоу                   |");
            Console.WriteLine("|_________________________________________________|");
        }
    }
}
