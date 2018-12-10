using System;

namespace SampleProject.learnCSharp
{
    class _05_IfElse
    {
        static void Main5(string[] args)
        {




            //If - else statement

            bool a = true;

            int b = 11;

            if (b == 10)
            {
                Console.WriteLine("B is 10");
            }
            else
            {
                Console.WriteLine("B is NOT 10");
            }

            Console.Read();







            //Nested If-else statement

            if (b != 20)
            {
                if (b == 10)
                {

                }
                else
                {
                    if (b == 5)
                    {
                        //Any number of nested if-else statements
                    }
                    else
                    {

                    }
                }
            }
            else
            {

            }


















        }
    }
}
