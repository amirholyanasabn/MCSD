using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[3];
            for (int i = 0; i < contacts.Length; i++)
            {
                Console.Clear();
                for (int j = 0; j < contacts.Length; j++)
                {
                    if (contacts[j]!= null)
                    {
                        Console.WriteLine($"{contacts[j].getName()}\t{contacts[j].getFamily()}\t{contacts[j].getPhoneNumber()}\t{contacts[j].getMobile()}");
                    }
                    Console.WriteLine("-------------------------------------------------------");
                    contacts[i] = new Contact();
                    Console.WriteLine("name : ");
                    contacts[i].setName(Console.ReadLine());
                    Console.WriteLine("family : ");
                    contacts[i].setFamily(Console.ReadLine());
                    Console.WriteLine("Phone : ");
                    contacts[i].setPhoneNumber(Console.ReadLine());
                    Console.WriteLine("mobile : ");
                    contacts[i].setMobile(Console.ReadLine());
                }
            }

            Console.WriteLine("Phone book is full . . .");
            Console.ReadKey();
        }
    }
}
