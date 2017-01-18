/* Задача 1: Centuries to Minutes
Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            var days = Math.Round(years * 365.2422);    //int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            uint minutes = (uint)(hours * 60);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
            // works as well with var only ;)
        }
    }
}
