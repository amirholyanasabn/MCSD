using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingByRefrenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            Console.WriteLine(number);
            ChangeInt(ref number);
            Console.WriteLine(number);
            Console.WriteLine("------------");
            DateTime date = new DateTime();
            Console.WriteLine(date);
            ChangeDateTime(ref date);
            Console.WriteLine(date);
            Console.WriteLine("------------");
            var name = "Amir";
            Console.WriteLine(name);
            ChangeText(ref name);
            Console.WriteLine(name);
            Console.WriteLine("------------");
            int[] numbers = new int[] { 10 };
            Console.WriteLine(numbers[0]);
            ChangeArray(ref numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine("-------------");
            Console.ReadKey();

        }

        static void ChangeInt(ref int number)
        {
            number++;
        }
        static void ChangeDateTime(ref DateTime dateTime)
        {
            dateTime=dateTime.AddDays(10);
        }
        static void ChangeText(ref string text)
        {
            text = "Hello " + text;
        }
        static void ChangeArray(ref int[] numbers)
        {
            numbers[0]++;
        }
    }
}
