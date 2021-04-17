using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Phone numbers do you want to add ?");
            int size = int.Parse(Console.ReadLine());

            string[] names = new string[size];
            string[] families = new string[size];
            string[] phones = new string[size];
            string[] cellPhones = new string[size];
          //  DateTime[] birthdates = new DateTime[size];
            var currentAddIndex = 0;

            while (true)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] != null)
                    {
                        Console.WriteLine($"{i+1},{names[i]},{families[i]},{phones[i]},{cellPhones[i]}");
                    }

                }
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1.add\n2.edit\n3.exit");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Pick an item from menue :");
                    var selectItem = int.Parse(Console.ReadLine());

                    switch (selectItem)
                    {
                        case 1:
                            if (currentAddIndex >= size)
                            {
                                Console.WriteLine("Phone book is full !");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("name : ");
                            names[currentAddIndex] = Console.ReadLine();
                            Console.WriteLine("family : ");
                            families[currentAddIndex] = Console.ReadLine();
                            Console.WriteLine("Phone : ");
                            phones[currentAddIndex] = Console.ReadLine();
                            Console.WriteLine("Cell Phone : ");
                            cellPhones[currentAddIndex] = Console.ReadLine();
                          /*  Console.WriteLine("birth date : ");
                            birthdates[currentAddIndex] = DateTime.Parse(Console.ReadLine());*/
                            currentAddIndex++;
                            break;
                        case 2:
                            Console.WriteLine("Enter index for edit : ");
                            var selectedIndex = int.Parse(Console.ReadLine());

                            Console.Write("name :");
                            names[selectedIndex] = Console.ReadLine();
                            Console.Write("family :");
                            families[selectedIndex] = Console.ReadLine();
                            Console.Write("phone :");
                            phones[selectedIndex] = Console.ReadLine();
                            Console.Write("cell phone :");
                            cellPhones[selectedIndex] = Console.ReadLine();
                           /* Console.Write("birth date :");
                            birthdates[selectedIndex] = DateTime.Parse(Console.ReadLine());*/
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("not valid.......");
                            Console.ReadKey();
                            break;
                    }
                   
                
                
            }
           

        }
    }
}
