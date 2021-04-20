using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1000, 2000);
            }
            MathOperations(nums, out int max, out int min, out double avg);
            Console.WriteLine($"max : {max}");
            Console.WriteLine($"min : {min}");
            Console.WriteLine($"avg : {avg}");

            Console.ReadKey();
        }
        static void MathOperations(int[] numbers , out int max ,out int min , out double avg)
        {
            max = numbers[0];
            min = numbers[0];
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
        }
    }
}
