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
            byte numberOfPersons = byte.Parse(Console.ReadLine());
            byte elevatorCapaciy = byte.Parse(Console.ReadLine());
            byte fullCources = (byte)(numberOfPersons / elevatorCapaciy);
            byte notFullCources = (byte)(numberOfPersons % elevatorCapaciy);
            if ((fullCources == 1)||(numberOfPersons < elevatorCapaciy))
            {
                Console.WriteLine("All the persons fit inside in the elevator. \nOnly one course is needed.");

            }
            else if (notFullCources != 0)
            {
                Console.WriteLine("{0} courses * {1} people + {2} course * {3} persons", fullCources, elevatorCapaciy, 1, notFullCources);
            }
            else
            {
                Console.WriteLine("{0} courses * {1} people", fullCources, elevatorCapaciy);
            }
        }
    }
}
