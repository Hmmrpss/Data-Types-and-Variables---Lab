using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main()
        {
            var numberOfLetters = int.Parse(Console.ReadLine()); 

            for (int first = 0; first < numberOfLetters; first++)
            {
                for (int second = 0; second < numberOfLetters; second++)
                {
                    for (int third = 0; third < numberOfLetters; third++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + first), (char)('a' + second), (char)('a' + third));
                    }
                }
            }
        }
    }
}