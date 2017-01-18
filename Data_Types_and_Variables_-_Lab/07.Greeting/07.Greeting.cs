/* Задача 7: Greeting
Write a program that enters first name, last name and age and prints "Hello, <first name> <last name>. You are <age> years old.". Use interpolated strings.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}. \r\n You are {2} years old.", firstName, lastName, age);
        }
    }
}
