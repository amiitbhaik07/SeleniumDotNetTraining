using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _01_02_RadiusCircumference
    {
        private const double pie = 3.14;

        static void Main_1_2(string[] args)
        {
            //Accept a decimal point number from console (a double data type) 
            //which will act as the radius and print area and circumference of the circle;
            //assume pi = 3.14;
            //Console should print message like 
            //"Area of the circle is 153.86 and circumference is 43.96".

            Console.WriteLine("Please enter the radius of that circle : ");

            double radius = Double.Parse(Console.ReadLine());

            double area = pie * radius * radius;

            double circumference = 2 * pie * radius;

            Console.WriteLine("Area of the circle is " + area.ToString("#.##") + " and circumference is " + circumference.ToString("#.##") + "");

            Console.Read();
        }
    }
}
