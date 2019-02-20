using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа АНКЕТА
            string name = "";
            string surname = "";
            string age = "";
            string high = "";
            string weight = "";
            Console.WriteLine("Программа АНКЕТА, введите личные данные");
            Console.WriteLine("Введите свое имя ");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию ");
            surname = Console.ReadLine();
            Console.WriteLine("Введите свой возраст ");
            age = Console.ReadLine();
            Console.WriteLine("Введите свой рос ");
            high = Console.ReadLine();
            Console.WriteLine("Введите свой вес ");
            weight = Console.ReadLine();

            Console.WriteLine("Ваше имя: " + name + ",\nВаша фамилия: " + surname + ",\nВаш возраст: " + age + ",\nВаш рост: " + high + ",\nВаш вес: " + weight );
            Console.ReadLine();

        }
    }
}
