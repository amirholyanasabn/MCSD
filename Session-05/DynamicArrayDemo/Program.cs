using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] actor = new string[]
            {
                "amirhossein","sepideh"
            };
            while (true)
            {
                Console.Clear();
            
                for (int i = 0; i < actor.Length; i++)
                    {
                         Console.WriteLine(actor[i]);
                    }
                Console.WriteLine("-------------------");
                Console.WriteLine("enter new name : ");
                var input = Console.ReadLine();
                AddToArray(ref actor, input);
                if (input == "exit")
                {
                    break;
                }
               
            }
            Console.WriteLine("enter name for remove : ");
            var removeInput = Console.ReadLine();
            RemoveFromArray(ref actor, removeInput);
            for (int i = 0; i < actor.Length; i++)
            {
                Console.WriteLine(actor[i]);
            }
            Console.ReadKey();
        }
        static void AddToArray(ref string[] names,string newName)
        {
            //var size = names.Length;
            string[] newNames = new string[names.Length+1];
            for (int i = 0; i < names.Length; i++)
            {
                newNames[i] = names[i];
            }
            newNames[newNames.Length - 1] = newName;
            names = newNames;

        }
        static void RemoveFromArray(ref string[] names,string removeName)
        {
            string[] newArray = new string[names.Length-1];
            for (int i = 0,j=0; i < names.Length; i++)
            {
                if (names[i] != removeName)
                {
                    newArray[j++] = names[i];
                }
            }
            names = newArray;
        }
    }
}
