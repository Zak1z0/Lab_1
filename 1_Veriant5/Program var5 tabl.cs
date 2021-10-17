using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Veriant5
{
    class Program
    {
        public enum Type { U = 1, A, T }
        public class TV
        {
            string show;
            string leader;
            int rating;
            Type t;

            public TV()
            {
            }

            public TV(string show, string leader, int rating, Type t)
            {
                this.show = show;
                this.leader = leader;
                this.rating = rating;
                this.t = t;
            }
            public void write()
            {
                Console.WriteLine("|" + show + " | " + leader + " | " + rating + " | " + t + "|");
            }

        }
        public static void Main(string[] args)
        {
            Console.Write("Введите первую передачю: "); string show1 = Console.ReadLine();
            Console.Write("Введите её ведущего: "); string leader1 = Console.ReadLine();
            Console.Write("Введите рейтинг: "); int rating1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип (1 - игровая; 2 - аналитическая; 3 – ток-шоу): ");
            string type1 = Console.ReadLine(); Type t1 = (Type)Convert.ToInt32(type1);
            TV T1 = new TV(show1,leader1,rating1,t1); 

            Console.Write("Введите вторую передачю: "); string show2 = Console.ReadLine();
            Console.Write("Введите её ведущего: "); string leader2 = Console.ReadLine();
            Console.Write("Введите рейтинг: "); int rating2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип (1 - игровая; 2 - аналитическая; 3 – ток-шоу): ");
            string type2 = Console.ReadLine(); Type t2 = (Type)Convert.ToInt32(type2);
            TV T2 = new TV(show2, leader2, rating2, t2); 

            Console.Write("Введите третью передачю: "); string show3 = Console.ReadLine();
            Console.Write("Введите её ведущего: "); string leader3 = Console.ReadLine();
            Console.Write("Введите рейтинг: "); int rating3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип (1 - игровая; 2 - аналитическая; 3 – ток-шоу): ");
            string type3 = Console.ReadLine(); Type t3 = (Type)Convert.ToInt32(type3);
            TV T3 = new TV(show3, leader3, rating3, t3); 

            Console.WriteLine("__________________________________");
            Console.WriteLine("|Передача |Ведущий |Рейтинг |Тип |");
            Console.WriteLine("|_________|________|________|____|");
            T1.write();
            Console.WriteLine("|_________|________|________|____|");
            T2.write();
            Console.WriteLine("|_________|________|________|____|");
            T3.write();
            Console.WriteLine("|_________|________|________|____|");
            Console.WriteLine("|Перечисляемый тип: И - игровая; |");
            Console.WriteLine("|            А - аналитическая;  |");
            Console.WriteLine("|            Т – ток-шоу         |");
            Console.WriteLine("|________________________________|");
        }
    }
}
