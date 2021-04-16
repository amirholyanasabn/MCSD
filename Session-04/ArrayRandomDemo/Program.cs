using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array : ");
            int count = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 10);
            }
            Console.WriteLine(string.Join("\t", numbers)); 
            Console.ReadKey();
        }
    }
}
