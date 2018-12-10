using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _02_02_PrintMultiples
    {
        static void Main_2_2(string[] args)
        {
            //Print all the multiples of 5 between 32 and 98

            for(int i=32; i<=98; i++)
            {
                if(i%5==0)
                    Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
