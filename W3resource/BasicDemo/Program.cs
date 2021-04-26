using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("First Number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int secNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum is : {firstNum+secNum}");
            Console.WriteLine($"Div is : {firstNum/secNum}");
            Console.ReadKey();
        }
    }
}
