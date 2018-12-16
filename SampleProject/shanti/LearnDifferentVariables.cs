using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnDifferentVariables
    {
        // bool, int, long, string, double  === DATA TYPES

        // 1) CLASS variable        ===>  always static

        // 2) INSTANCE variable     ===> Never static

        // 3) LOCAL variable        ===> Never static

        [Test]
        public void abc()
        {

            //Class variables DON'T need instance
            Employee1.organizationName = "";

            //Access the instance variables requires instance of that particular class
            Employee1 e1 = new Employee1();
            e1.name = "";

            //Local variables of another class CAN'T be accessed from outside!
            //e1.j = 9;         // NOT POSSIBLE because j is a local variable defined inside a method
        }
    }

    class Employee1
    {
        public enum GENDER { MALE, FEMALE }

        //CLASS variable:
        public static string organizationName = "TCS";

        //Instance variable:
        public string name;

        //Instance variable:
        public int age;

        //Instance variable:
        public GENDER gender;

        public Employee1()
        {
            //Local variable:
            int a = 20;
        }

        public void asdfsf()
        {
            organizationName = "sdfasf";

            name = "asdfadsfv";

            //Another local variable defined inside the for loop
            for(int i=0; i<10; i++)
            {
                i = 8;
            }

            //i = 9;        //i cannot be used outside for loop




            int j;          //Declare outside for loop
            for (j=0; j<10; j++)        //Initialize it here
            {
                j = 8;
            }

            j = 9;          // Now it is accessible outside for loop.
        }
    }
}
