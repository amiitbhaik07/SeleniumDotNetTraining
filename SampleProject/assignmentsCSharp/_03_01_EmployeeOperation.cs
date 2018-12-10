using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _03_01_EmployeeOperation
    {
        static void Main_3_1(string[] args)
        {

        }
    }

    class Employee
    {
        public enum GENDER { MALE , FEMALE }
        private static int idCounter = 1;
        public int id;
        public string name;
        public int age;
        public GENDER gender;

        Employee(string name, int age, GENDER gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.id = idCounter++;
        }
    }
}
