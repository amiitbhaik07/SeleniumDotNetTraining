using System;

namespace SampleProject.learnCSharp
{
    class _02_ConsoleOperations
    {
        static void Main2(string[] args)
        {
            //Writing on Console
            Console.WriteLine("This would be written on Console");

            //Reading from Console
            Console.WriteLine("Let us read from Console.");

            //Read the Line
            Console.WriteLine("Now lets read a line");
            string line = Console.ReadLine();
            Console.WriteLine(line);

            //ASCII value of the character
            int ch = Console.Read();
            Console.WriteLine("ASCII code is " + ch);


            Console.Read();
        }
    }
}
