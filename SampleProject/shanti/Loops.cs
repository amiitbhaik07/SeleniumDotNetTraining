using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class Loops
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("1");

            //FOR Loop      90%

            for(  int i = 0    ;   i < 50    ;   i++   )
            {
                Console.WriteLine(i);
            }


            //INFINITE WHILE LOOP

            //WHILE Loop        8%
            int j = 100;
            while( j < 20 )
            {
                Console.WriteLine(j);
                j++;
            }

            // nothing on console




            //DO - WHILE loop       2%

            int k = 100;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while ( k < 15 );

            //100


            Console.Read();
        }
    }
}
