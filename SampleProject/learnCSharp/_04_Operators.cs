using System;

namespace SampleProject.learnCSharp
{
    class _04_Operators
    {
        static void Main4(string[] args)
        {


            //Arithmetic

            int a = 10;

            int b = a + 20;                 //Addition

            int c = a - 5;                  //Subtraction

            int d = a * 5;                  //Multiplication

            int e = a / 5;                  //Division

            int f = a % 5;                  //Modulus

            a++;                            //Unary operator - Increment

            a--;                            //Unary operator - Decrement










            //Relational Operators

            if (a == 10) { }

            if (a != 10) { }

            if (a > 10) { }

            if (a >= 10) { }

            if (a < 10) { }

            if (a <= 10) { }









            //Logical Operators

            if (true && false) { }

            if (true || false) { }

            if (!(true)) { }
















            Console.Read();
        }
    }
}
