using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _01_01_MultiplicationTable
    {
        static void Main_1_1(string[] args)
        {
            //Accept a number from console and print its multiplication table till nx10.

            Console.WriteLine("Please enter any number:");

            int number = Int32.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(number + " x " + i  + " = " + number*i );
            }

            Console.Read();
        }
    }
}
