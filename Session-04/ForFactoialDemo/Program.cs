using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFactoialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number : ");
            int result = 1;
            for(var number = int.Parse(Console.ReadLine());number >1;number--)
            {
                result *= number;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
