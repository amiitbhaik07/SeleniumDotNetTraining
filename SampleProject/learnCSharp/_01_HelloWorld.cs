using System;

namespace SampleProject.learnCSharp
{
    class _01_HelloWorld
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World! Please enter your name :");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", let's build our first script...");

            Console.Read();
        }
    }
}
