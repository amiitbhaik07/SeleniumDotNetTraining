using System;

namespace SampleProject.learnCSharp
{
    class _03_VariablesDataTypes
    {
        static void Main3(string[] args)
        {


            //Data Types primarily used in Selenium

            bool b = true;

            char ch = 'a';

            decimal de = 3.14M;

            double d = 3.14;

            float fl = 3.14F;

            int i = 2;

            long l = 2;







            //Using var

            var v = "Hi there!";

            //v = true;             //Error

            Console.WriteLine(v);







            //Using dynamic

            dynamic dy = 3.14;

            Console.WriteLine(dy);

            dy = true;

            Console.WriteLine(dy);

            dy = "Changed to string";

            Console.WriteLine(dy);










            //Strings

            string str = "Hello World!";

            Console.WriteLine(str);

            str = "New string";

            Console.WriteLine(str);







            //String to different data types

            str = "35";

            Console.WriteLine(str + 10);

            int q2 = Int32.Parse(str);

            //Now q2 holds integer value of 35

            q2 = q2 + 10;

            Console.WriteLine(q2);








            //Only declare variables, use later

            int abc;            //Declaration

            abc = 55;           //Initialization

            int p = abc + 10;   //Usage

            //Declare and initialize together, use later

            int pqr = 55;









            Console.Read();
        }
    }
}
