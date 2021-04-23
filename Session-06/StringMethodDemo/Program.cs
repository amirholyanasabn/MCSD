using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              Hello      "+"   John         ");
            Console.WriteLine("              Hello      ".Trim()+"   John         ");

            Console.WriteLine("C# is good language"[3]);
            Console.WriteLine("I like java and spring framwork.".Contains("c#"));
            Console.WriteLine("C# is best program language for iranian".Replace("best","top10"));
            string[] name = new string[] { "amirhossein", "sepideh", "vana", "ali" };
            var isOK=name.Contains("vana");
            Console.WriteLine(isOK);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter persian date : ");
            var input = Console.ReadLine().Split('/');
            Console.WriteLine($"year {input[0]} , month {input[1]} , day {input[2]}");
            Console.ReadKey();
            
        }
    }
}
