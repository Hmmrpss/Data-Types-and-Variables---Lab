/* 5.Special Numbers
A number is special when its sum of digits is 5, 7 or 11.
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main()
        {
            //gets count of all the numbers
            var nNumbersToCheck = int.Parse(Console.ReadLine());
            //checks all the numbers from 1 to nNumbersToCheck
            for (int i = 1; i <= nNumbersToCheck; i++)
            {
                Console.WriteLine("{0} -> {1}", i, SpecialNumberChecker(i)); //checks if the number is special and prints out the result
			}
        }
               
        static bool SpecialNumberChecker(int currentNumber)
        {
            bool specialNumber = false;
            if ((SumOfItsDigits(currentNumber) == 5) || (SumOfItsDigits(currentNumber) == 7) || (SumOfItsDigits(currentNumber) == 11))
                {
                    specialNumber = true;
                }
              else
              {
                  specialNumber = false;
              }
            return specialNumber;
        }

        static int SumOfItsDigits(int currentNumber)
        {
            var sumOfItsDigits = 0;
            while (currentNumber > 0)
            {
                sumOfItsDigits += currentNumber % 10;
                currentNumber /= 10;
            }
            return sumOfItsDigits;
        }
    }
}