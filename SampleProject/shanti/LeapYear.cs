using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LeapYear
    {
        static void Main412(string[] args)
        {
            int year = 2100;
            bool isLeap;

            if( year % 4 == 0 )
            {
                //Year is exactly divisible by 4    

                if(year % 100 == 0)
                {
                    //Year is exactly divisible by 100
                    if(year % 400 == 0)
                    {
                        //Year exactly divisible by 400
                        isLeap = true;
                    }
                    else
                    {
                        //Year is NOT divisible by 400
                        isLeap = false;
                    }
                }
                else
                {
                    //Year is NOT divisible by 100
                    isLeap = true;
                }
            }
            else
            {
                //Year is NOT divisible by 4
                isLeap = false;                 //1999
            }


            if(isLeap)
                Console.WriteLine("LEAP");
            else
                Console.WriteLine("NOT LEAP");

            Console.Read();
        }
    }
}
