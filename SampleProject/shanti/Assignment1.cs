using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class Assignment1
    {
        static void Main(string[] abc)
        {
            Console.WriteLine("Hello please enter the radius of circle.");

            //double radius = Double.Parse(Console.ReadLine());

            //double area = radius * radius * 3.14;

            //double circumference = 2 * 3.14 * radius;

            //Console.WriteLine("Area of the circle is : " + area);

            //Console.WriteLine("Circumference of the circle is : " + circumference);

            //Tell a number is EVEN or ODD

            Console.WriteLine("Please enter a number");

            int number = Int32.Parse(Console.ReadLine());

            if(number % 2 == 0)
                Console.WriteLine("Number is EVEN");
            else
                Console.WriteLine("Number is ODD");

            Console.Read();
        }
    }
}
