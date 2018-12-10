using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _02_01_NumberPrinting
    {
        static void Main_2_1(string[] args)
        {
            //Print a list of numbers starting from 10 to 50


            //1) For loop
            for(int i=10; i<=50; i++)
                Console.WriteLine(i);

            Console.WriteLine();


            //2) While loop
            int j = 10;
            while(j < 51)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();


            //3) Do-While loop
            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 51);




            Console.Read();
        }
    }
}
