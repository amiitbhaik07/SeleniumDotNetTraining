using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _01_03_OddEven
    {
        static void Main_1_3(string[] args)
        {
            //Accept a number from console and tell whether it is ODD or EVEN

            Console.WriteLine("Please enter a number on console");

            int number = Int32.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("Number " + number + " is EVEN");
            }
            else
            {
                Console.WriteLine("Number " + number + " is ODD");
            }

            Console.Read();
        }
    }
}
