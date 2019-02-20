using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1___part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа обмена значениями в переменных
            int a = 0;
            int b = 0;
            Console.WriteLine("програама обмена значений в переменных");
            Console.WriteLine("Введите знчение целочисленной переменной a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знчение целочисленной переменной b");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("значние a = " + a + "\nзначние b = " + b);
            Console.ReadLine();
        }
    }
}
