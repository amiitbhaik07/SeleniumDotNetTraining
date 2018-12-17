using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnLists
    {
        [Test]
        public void abc()
        {
            // Collections - List

            //List<string> allNames = new List<string>();

            //List<Employee> allEmployees = new List<Employee>();


            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);




            Console.WriteLine();

            int numAt4 = numbers[3];

            int totalCount = numbers.Count;

            int last = numbers[totalCount-1];

            Console.WriteLine();

            bool contains2 = numbers.Contains(2);

            bool contains10 = numbers.Contains(10);


            //numbers.Remove(1);


            //Console.WriteLine();


            //numbers.Add(1);

            //Console.WriteLine();

            //numbers.RemoveAt(1);

            numbers.Reverse();

            Console.WriteLine("All the list of numbers:");
            
            foreach(int a in numbers)
                Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();





        }
    }
}
