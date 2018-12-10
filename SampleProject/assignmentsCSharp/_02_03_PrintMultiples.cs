using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _02_03_PrintMultiples
    {
        static void Main_2_3(string[] args)
        {
            //Print all the numbers between 13 and 92 which are multiples of either 3, 4 or 7 
            //but are NOT multiples of 6 or 8

            for(int i=13; i<=92; i++)
            {
                if(i%3==0 || i%4==0 || i%7==0)
                {
                    //Number is a multiple of either 3, 4 or 7
                    if(!(i%6==0 || i%8==0))
                    {
                        //Number is a multiple of either 3, 4 or 7 BUT not multiple of 12 or 17
                        Console.WriteLine(i);
                    }
                }
            }

            Console.Read();
        }
    }
}
