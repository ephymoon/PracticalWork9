using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void TimeToHMS(int time, out int hours, out int minutes, out int seconds)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
            if (time >= 3599)
            {
                hours = time / 3600;
                time -= hours * 3600;
            }
            if (time >= 59)
            {
                minutes = time / 60;
                time -= minutes * 60;
            }
            if (time >= 0)
            {
                seconds = time;
            }
        }
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            Console.WriteLine("Программа перевода секунд.\nВведите кол-во секунд:");
            int time = Convert.ToInt32(Console.ReadLine());
            TimeToHMS(time, out hours, out minutes, out seconds);
            Console.WriteLine("Результат:");
            Console.WriteLine("Часы - " + hours);
            Console.WriteLine("Минуты - " + minutes);
            Console.WriteLine("Секунды - " + seconds);
            Console.Write("Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}
