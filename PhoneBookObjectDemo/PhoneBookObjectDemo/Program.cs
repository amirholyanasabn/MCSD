using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[10];

            for (int i = 0; i <contacts.Length; i++)
            {
                Console.Clear();
                for (int j = 0; j < contacts.Length; j++)
                {
                    if (contacts[j] != null)
                    {
                        Console.WriteLine($"{contacts[j].getName()}\t{contacts[j].getFamily()}\t{contacts[j].getPhone()}\t{contacts[j].getMobile()}");
                    }
                }
                Console.WriteLine("_______________________________________________________");

                 
                contacts[i] = new Contact();

                Console.Write("Name : ");
                contacts[i].setName(Console.ReadLine());
                Console.Write("Family : ");
                contacts[i].setFamily(Console.ReadLine());
                Console.Write("Phone : ");
                contacts[i].setPhone(Console.ReadLine());
                Console.Write("Mobile : ");
                contacts[i].setMobile(Console.ReadLine());
                  
            }
            Console.WriteLine("Phonebook is full !!!");
            Console.ReadKey();
        }

    }
}
