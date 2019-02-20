using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1___pat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа расчета индекса массы человекаа
            int high = 0;
            int weight = 0;
            Console.WriteLine("Программа расчета индекса массы человекаа, введите личные данные");
            Console.WriteLine("Введите свой рос в метрах");
            high = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой вес  в килограммах");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше индекс массы = " + (weight/(high + high)) );
            Console.ReadLine();
        }
    }
}
