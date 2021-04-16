using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqeRandomArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            int[] randomNumbers = new int[50];
           
            stopwatch.Start();
            for (int i = 0; i < randomNumbers.Length;)
            {
                var randomNumber = random.Next(1, 100);
                bool isUniqe = true;
                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[j]==randomNumber)
                    {
                        isUniqe = false;
                        break;
                    }
                }
                if (isUniqe)
                {
                    randomNumbers[i++] = randomNumber;
                }
            }
            stopwatch.Stop();
            Array.Sort(randomNumbers);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
