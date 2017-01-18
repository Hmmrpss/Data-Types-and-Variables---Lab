/* Задача 3: Exact Sum of Real Numbers
Write program to enter n numbers and calculate and print their exact sum (without rounding).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            byte numbersToSum = byte.Parse(Console.ReadLine());
            decimal sum = 0;
            while (numbersToSum > 0)
            {
                sum += decimal.Parse(Console.ReadLine());
                numbersToSum--;
            }
            Console.WriteLine(sum);
        }
    }
}
