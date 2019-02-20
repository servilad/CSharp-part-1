using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1___part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа вывода на экран с разными координатами
            string name = "";
            string surname = "";
            string town = "";
            string rez = "";
            int x;
            int y;
            Console.WriteLine("Программа форматированной вывода на экран данных пользователя, введите личные данные");
            Console.WriteLine("Введите свое имя ");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию ");
            surname = Console.ReadLine();
            Console.WriteLine("Введите город в котором проживаете ");
            town = Console.ReadLine();
            Console.WriteLine("Введите положение по горизонтали ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите положение по вертикали");
            y = int.Parse(Console.ReadLine());
            rez ="Ваше имя: <" + name + "> Ваша фамилия: <" + surname + "> Город в котором проживаете: <" + town + ">";
            PrintXY(rez, x, y);
            Console.ReadLine();
        }

        static void PrintXY(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }
}
