using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 10;
            Console.WriteLine(num);
            ChangeInt(num);
            Console.WriteLine(num);
            Console.WriteLine("--------------------");

            DateTime dateTime = new DateTime();
            Console.WriteLine(dateTime);
            ChangeDateTime(dateTime);
            Console.WriteLine(dateTime);
            Console.WriteLine("----------------------");

            var name = "Amir";
            Console.WriteLine(name);
            ChangeString(name);
            Console.WriteLine(name);
            Console.WriteLine("-------------------------");

            int[] numbers = new int[] { 12, 45, 6, 77, 89, 90, 123 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            ChangeArray(numbers);
            Console.WriteLine("---");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }

        static void ChangeInt(int number)
        {
            number++;
        }

        static void ChangeDateTime(DateTime dt)
        {
            dt = dt.AddDays(10);
        }
        static void ChangeString(string text)
        {
            text = "Hello " + text;
        }
        static void ChangeArray(int[] numbers)
        {
            numbers[0]++;
        }
    }
}
