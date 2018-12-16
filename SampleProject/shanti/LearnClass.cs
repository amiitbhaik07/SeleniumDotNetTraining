using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SampleProject.shanti.Employee;

namespace SampleProject.shanti
{
    class LearnClass
    {
        //Collection of objects

        //Employee of any organization

        //Name, Age, Gender, Address, Bank Account No., Salary, Organization Name

        // Shanti : 

        // Employee 2 :

        [Test]
        public void CreateEmployees()
        {
            Employee e1 = new Employee();
            e1.name = "Amit";
            e1.age = 26;
            e1.gender = GENDER.MALE;

            Employee e11 = new Employee("Amit", 26, GENDER.MALE);


            Employee e2 = new Employee();
            e2.name = "Rohan";
            e2.age = 25;
            e2.gender = GENDER.MALE;


            Console.WriteLine(e1);

        }

    }

    class Employee
    {
        public enum GENDER { MALE , FEMALE }

        public string name;

        public int age;

        public GENDER gender;


        //Constructor ? ==> The one who constructs/initialize the values for any object/class


        public Employee()           // 1) PARAMETER-LESS constructor This is called as constructor
        {

        }


        // 2) Parametrized constructor

        public Employee(string name, int age, GENDER gender)
        {
            this.name = name;

            this.age = age;

            this.gender = gender;
        }
    }



}
