using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static bool Check (int i)
        {
            if ( (i % 2 == 0) || (i % 7 == 0) )
                if ( (i % 15 != 0) && (i % 28 != 0) && (i % 41 != 0))
                    return true;
            return false;
        }
        
        static void Minmax (int i, ref int min, ref int max)
        {
            if (i<min) min = i; 
            if (i>max) max = i;
        }
        static void Main(string[] args)
        {
            int min = 10000, max = 0;
            Console.WriteLine("Программа нахождения мин макс.");
            for (int i = 3232; i < 8300; i++)
            {
                if (Check (i))
                    Minmax(i, ref min, ref max);
            }
            Console.Write("Минимальное число: " + min + "\nМаксимальное число: " + max + "\n");
            Console.Write("Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}
