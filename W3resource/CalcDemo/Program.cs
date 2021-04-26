using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int secNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum}+{secNum}={firstNum+secNum}");
            Console.WriteLine($"{firstNum}-{secNum}={firstNum-secNum}");
            Console.WriteLine($"{firstNum}*{secNum}={firstNum*secNum}");
            Console.WriteLine($"{firstNum}/{secNum}={firstNum/secNum}");
            Console.WriteLine($"{firstNum}mod{secNum}={firstNum%secNum}");
            Console.ReadKey();
        }
    }
}
