using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Number : ");
            double fourthNum = double.Parse(Console.ReadLine());
            double sum = firstNum + secondNum + thirdNum + fourthNum;
            double avg = sum / 4;
            Console.WriteLine($"The average of {firstNum} , {secondNum} , {thirdNum} , {fourthNum} is : {avg}");
            Console.ReadKey();
        }
    }
}
