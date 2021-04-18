using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteCurrentPersianDate();
            Console.WriteLine("Please enter size of array :");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please enter number \"{i+1}\" :");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------------------");
            WriteMinimumNumber(nums);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Max number is {GetMaxNumber(nums)}");
            double[] numbers = new double[] { 12.90, 9.98,17.7,7.80,35.78,12.09,66.90 };
            WriteMinimumNumber(numbers);
            Console.ReadKey();
        }
        
        static void WriteCurrentPersianDate()
        {
            var pc = new PersianCalendar();
            Console.WriteLine($"{pc.GetYear(DateTime.Now)}-{pc.GetMonth(DateTime.Now)}-{pc.GetDayOfMonth(DateTime.Now)}");
        }

        static void WriteMinimumNumber(int[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Minimum number is : {min}");
        }

        static void WriteMinimumNumber(double[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Minimun number is : {min}");
        }
        static int GetMaxNumber(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        
    }
}
