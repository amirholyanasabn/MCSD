using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWithout
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[50];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbers.Length; /*i++*/)
            {
                var randomNumber = random.Next(1, 100);
                bool isUniqe = true;
                for (int j = 0; j <i ; j++)
                {
                    if (numbers[j]==randomNumber)
                    {
                        isUniqe = false;
                        break;
                    }
                }
                if (isUniqe)
                {
                    numbers[i++] = randomNumber;
                }
            }
            stopwatch.Stop();
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
