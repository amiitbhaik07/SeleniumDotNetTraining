using System.Collections.Generic;

namespace SampleProject.learnCSharp
{
    class _06_SwitchLoopsControlStatements
    {
        static void Main6(string[] args)
        {

            //Loops : 
            //  1)  While loop
            //  2)  Do-While loop
            //  3)  For loop
            //  4)  Foreach loop

            //Control Statements : break , continue


            //  1)  While loop

            int a = 0;

            while (a != 10)
            {
                a++;
            }






            //  2)  Do-While loop

            int b = 0;

            do
            {
                b++;
            }
            while (b != 10);








            //  3)  For loop

            for (int i = 0; i < 10; i++)
            {

            }







            //  4)  Foreach loop

            List<string> collection = new List<string>();

            foreach (string item in collection)
            {

            }









            //Switch statement

            int c = 20;

            switch (c)
            {
                case 1:

                    break;

                case 2:
                    break;
            }














        }
    }
}
