using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // MathOperations(out int mini,out int max , out double avg ,new int[] { 12,44,66,90,80,6,12,33});
            MathOperations(out int min, out int max, out double avg, 12, 44, 66, 90, 80, 6, 12, 33);
        }
        static void MathOperations(out int min,out int max , out double avg, params int[] numbers)
        {
            min = numbers[0];
            max = numbers[0];
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];

            }
            avg = sum / numbers.Length;
        }
    }
}
