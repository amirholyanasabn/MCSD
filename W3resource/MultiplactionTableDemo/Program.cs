using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplactionTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine($"{number} * {i} = {number*i}");
            }
            Console.ReadKey();
        }
    }
}
