using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _01_04_LeapYear
    {
        static void Main_1_4(string[] args)
        {
            int year = 2100;
            bool isLeap = false;

            if(year % 4 == 0)
            {
                //Year is divisible by 4, MIGHT be a leap year

                if(year % 100 == 0)
                {
                    //Year is divisible by 100

                    if(year % 400 == 0)
                    {
                        //Year is divisible by 100 as well as by 400, hence a leap year
                        isLeap = true;
                    }
                    else
                    {
                        //Year is divisible by 100, but not 400; hence NOT a leap year.
                        isLeap = false;
                    }
                }
                else
                {
                    //Year is not divisible by 100, but is divisible by 4, hence a leap year
                    isLeap = true;
                }
            }
            else
            {
                //Not divisible by 4, definitely NOT a leap year
                isLeap = false;
            }

            if(isLeap)
                Console.WriteLine("Year '" + year + "' is a leap year!");
            else
                Console.WriteLine("Year '" + year + "' is NOT a leap year!");

            Console.Read();
        }
    }
}
