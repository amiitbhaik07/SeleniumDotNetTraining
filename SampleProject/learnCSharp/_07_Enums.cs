using System;

namespace SampleProject.learnCSharp
{
    class _07_Enums
    {
        enum DAYS { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY };

        static void Main7(string[] args)
        {

            DAYS d = DAYS.SATURDAY;

            PrintDay(d);

            Console.Read();
        }

        static void PrintDay(DAYS d)
        {
            Console.WriteLine(d.ToString());
        }
    }
}
