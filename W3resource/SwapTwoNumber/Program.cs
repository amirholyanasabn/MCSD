using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int secNum = int.Parse(Console.ReadLine());
            var swap = firstNum;
            firstNum = secNum;
            secNum = swap;
            Console.WriteLine($"First number is {firstNum} and Second number is {secNum}");
            Console.WriteLine("Third Number : ");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum}*{secNum}*{thirdNum} : {firstNum*secNum*thirdNum}");
            Console.ReadKey();
        }
    }
}
