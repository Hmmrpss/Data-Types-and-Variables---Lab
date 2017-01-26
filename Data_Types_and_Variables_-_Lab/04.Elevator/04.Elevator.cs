/* Задача 4: Elevator
Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main()
        {
            var numberOfPersons = double.Parse(Console.ReadLine());                     //uint numberOfPersons
            var elevatorCapaciy = double.Parse(Console.ReadLine());                     //uint elevatorCapaciy
            var elevatorCources = (int)Math.Ceiling(numberOfPersons / elevatorCapaciy); //var elevatorCources = (int)Math.Ceiling((double)numberOfPersons / elevatorCapaciy);
            Console.WriteLine(elevatorCources);
        }
    }
}