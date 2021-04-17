using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of menue : ");
            int size = int.Parse(Console.ReadLine());
            string[] foodNames = new string[size];
            int[] countOfMaterials = new int[size];
            string[] firstMaterial = new string[size];
            string[] secondMaterial = new string[size];
            string[] thirdMaterial = new string[size];
            double[] firstWeightOfMaterial = new double[size];
            double[] secondWeightOfMaterial = new double[size];
            double[] thirdWeightOfMaterial = new double[size];
            var currentAddIndex = 0;
            while (true)
            {
                Console.Clear();
              
                    Console.WriteLine("1.show recipe\n2.add recipe\n3.delete\n4.exit");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("selecet one of them : ");
                    var selectItem = int.Parse(Console.ReadLine());
                    switch (selectItem)
                    {
                        case 1:
                        for (int i = 0; i < size; i++)
                        {
                            if (foodNames != null)
                            {
                                Console.WriteLine($"{i + 1} - {foodNames[i]} - {countOfMaterials[i]} - {firstMaterial[i]} - {firstWeightOfMaterial[i]} - {secondMaterial[i]} - {secondWeightOfMaterial[i]} - {thirdMaterial[i]} - {thirdWeightOfMaterial[i]}");

                            }
                        }
                        Console.WriteLine("-------------------------------------------------------------");
                        break;
                    case 2:
                        if (currentAddIndex >=size)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("List of recipe is full !");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("food name :");
                        foodNames[currentAddIndex] = Console.ReadLine();
                        Console.WriteLine("count of materials :");
                        countOfMaterials[currentAddIndex] = int.Parse(Console.ReadLine());
                        Console.WriteLine("name of first material :");
                        firstMaterial[currentAddIndex] = Console.ReadLine();
                        Console.WriteLine("weight of first material :");
                        firstWeightOfMaterial[currentAddIndex] = double.Parse(Console.ReadLine());
                        Console.WriteLine("name of second material :");
                        secondMaterial[currentAddIndex] = Console.ReadLine();
                        Console.WriteLine("weight of second material :");
                        secondWeightOfMaterial[currentAddIndex] = double.Parse(Console.ReadLine());
                        Console.WriteLine("name of third material :");
                        thirdMaterial[currentAddIndex] = Console.ReadLine()
                        Console.WriteLine("weight of third material");
                        thirdWeightOfMaterial[currentAddIndex] = double.Parse(Console.ReadLine());
                        currentAddIndex++;
                        break;
                    case 3:
                        Console.WriteLine("please choose number one of them for edit :");
                        var selectIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("food name :");
                        foodNames[selectIndex] = Console.ReadLine();
                        Console.WriteLine("count of materials :");
                        countOfMaterials[selectIndex] = int.Parse(Console.ReadLine());
                        Console.WriteLine("name of first material :");
                        firstMaterial[selectIndex] = Console.ReadLine();
                        Console.WriteLine("weight of first material :");
                        firstWeightOfMaterial[selectIndex] = double.Parse(Console.ReadLine());
                        Console.WriteLine("name of second material :");
                        secondMaterial[selectIndex] = Console.ReadLine();
                        Console.WriteLine("weight of second material :");
                        secondWeightOfMaterial[selectIndex] = double.Parse(Console.ReadLine());
                        Console.WriteLine("name of third material :");
                        thirdMaterial[selectIndex] = Console.ReadLine();
                        Console.WriteLine("weight of third material :");
                        thirdWeightOfMaterial[selectIndex] = double.Parse(Console.ReadLine());
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("wrong......................");
                            break;
                    }

                
                
            }
        }
    }
}
