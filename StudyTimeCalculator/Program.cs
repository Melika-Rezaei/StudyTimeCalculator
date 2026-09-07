using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTimeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times?");
            int num = int.Parse(Console.ReadLine()); 
            
            int[] ArrayTimes = new int[num];
            int sumNumbers = 0;
            int HourOfNum = 0, MinOfNum = 0;

            for (int i = 0; i < num ; i++)
            {
                Console.WriteLine($"Enter the number {i + 1} in minutes: ");
                ArrayTimes[i] = int.Parse(Console.ReadLine());
            }

            foreach (int val in ArrayTimes)
            {
                sumNumbers += val;
            }

            HourOfNum = sumNumbers / 60;
            MinOfNum = sumNumbers % 60;
            Console.WriteLine(sumNumbers);
            Console.WriteLine($"The Total is: {HourOfNum}:{MinOfNum:D2}");
        }
    }
}
