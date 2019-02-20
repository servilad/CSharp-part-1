using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1___part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа расчета между точками
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            Console.WriteLine("Программа расчета математической формулы");
            Console.WriteLine("Введите последовательно две координаты X и Y точки 1");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательно две координаты X и Y точки 2");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ  = {0:F2}", res(x1, y1, x2, y2));
            Console.ReadLine();
            
        }
        static double res(double x1,double y1,double x2, double y2)
        {
            double rezult = 0;
            return rezult = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
