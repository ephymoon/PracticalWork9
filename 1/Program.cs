using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static int min(int x, int y)
        {
            if (x > y)
                return y;
            else
                return x;
        }

        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Программа нахождения минимального числа среди двух.\nВведите числа:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минимальное число:");
            if (min(a, b) > min(c, d))
                Console.WriteLine(min(c, d));
            else
                Console.WriteLine(min(a, b));
            Console.Write("Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}
