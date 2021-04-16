using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Amirhossein",
                "Gucci","Sepideh","Majid"
            };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
