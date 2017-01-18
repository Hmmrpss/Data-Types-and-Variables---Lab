/* Задача 9: Refactor Special Numbers
You are given a working code that is a solution to Problem 5. Special Numbers. However, the variables are improperly named, declared before they are needed and some of them are used for multiple things. Without using your previous solution, modify the code so that it is easy to read and understand.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            int sumOfItsDigits = 0; 
            int number = 0; 
            for (int current = 1; current <= numberToCheck; current++)
            {
                number = current;
                while (current > 0)
                {
                    sumOfItsDigits += current % 10;
                    current = current / 10;
                }
                bool magicNumber = (sumOfItsDigits == 5) || (sumOfItsDigits == 7) || (sumOfItsDigits == 11);
                Console.WriteLine("{0} -> {1}", number, magicNumber);
                sumOfItsDigits = 0;
                current = number;
            }
        }
    }
}
