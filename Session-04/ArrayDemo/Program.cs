using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array size : ");
            int size = int.Parse(Console.ReadLine());
            //string[] names = new string[size];
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"please enter number \" {i+1} \" : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}\t");
            //}
            Console.WriteLine(string.Join("\t",numbers));
            Console.WriteLine("\n----------------------------");
            var sum=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(Convert.ToDouble(sum)/Convert.ToDouble(numbers.Length));
            // Console.WriteLine($"Average of array is : {sum/numbers.Length}");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.Write($"{numbers[i]}\t");
                }
            }
            Console.ReadKey();
        }
    }
}
