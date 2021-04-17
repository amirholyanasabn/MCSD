using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number : ");
            for(var number =int.Parse(Console.ReadLine());number>1;number--)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey(); 
        }
    }
}
