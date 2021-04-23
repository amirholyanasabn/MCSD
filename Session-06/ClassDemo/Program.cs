using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Amirhossein";
            person.Family = "Olyanasab";

            Console.WriteLine($"Name is : {person.Name}\tFamily is : {person.Family}");
            Console.ReadKey();
        }
    }
}
