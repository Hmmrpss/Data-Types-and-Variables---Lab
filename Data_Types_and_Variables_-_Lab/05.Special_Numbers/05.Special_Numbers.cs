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
            int numberToCheck = int.Parse(Console.ReadLine());
            int sumOfItsDigits = ((numberToCheck/10)+(numberToCheck%10));
            bool magicNumber = ((sumOfItsDigits == 5) || (sumOfItsDigits == 7) || (sumOfItsDigits == 11));
            for (int i = 1; i <= numberToCheck; i++)
            {
                Console.WriteLine("{0} -> {1}", i, magicNumber);
            }
        }
    }
}
