using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ______                    _ ");
            Console.WriteLine("  / ____/__  __ _____ _____ (_)");
            Console.WriteLine(" / / __ / / / // ___// ___// / ");
            Console.WriteLine("/ /_/ // /_/ // /__ / /__ / /  ");
            Console.WriteLine("\\____/ \\__,_/ \\___/ \\___//_/   ");
            Console.WriteLine("                               ");
            Thread.Sleep(5000);
            Console.Clear();
            //CounntDown(10, 4, 2);
            //Console.WriteLine("---------");
            //CounntDown(10);
            //Console.WriteLine("-----------------");
            CounntDown(10, interval: 2);
            Console.ReadKey();
        }
        static void CounntDown(int start,int finish = 0, int interval = 1)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;
             
            for (int i = start; i > finish; i = i- interval)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2);
                Console.Beep(100,500);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
