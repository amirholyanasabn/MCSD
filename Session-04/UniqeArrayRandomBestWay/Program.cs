using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqeArrayRandomBestWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] domain = new int[1000000]; //تعریف یک آرایه جهت دامنه -بازه اعدادی که عدد تصادفی تولید کنیم
            for (int i = 0; i < domain.Length; i++)/*  پر کردن آرایه از اعداد یک تا یک میلون*/
            {
                domain[i] = i + 1;
            }
            Stopwatch stopwatch = new Stopwatch(); 
            stopwatch.Start();
            Random random = new Random();
            int[] randomNumbers = new int[400000]; //تعریف آرایه اصلی به تعداد 400-000
            for (int i = 0; i < randomNumbers.Length; i++) //پر کردن آرایه
            {
                var randomIndex = random.Next(0, domain.Length - i);//تولید یک عدد تصادفی بین صفر تا طول دامین منهای شمارنده
                randomNumbers[i] = domain[randomIndex];//عدد تصادفی را به عنوان ایندکس دامین میدهیم و مقدار را در آرایه اصلی میریزیم
                domain[randomIndex] = domain[domain.Length - 1 - i];//پاک کردن از انتهای آرایه کمکی
            }
            stopwatch.Stop();
            Array.Sort(randomNumbers);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
