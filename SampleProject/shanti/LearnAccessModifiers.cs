using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnAccessModifiers
    {
        // Access Modifiers


        [Test]
        public void abc()                           // WORLD
        {
            Company c = new Company();

            c.companyWebsite = "afasdf";            // Only public data members are accessible to the outer world (to other classes)

            //c.employeeLogin = "efsdf";            // protected data members cannot be accessed

            //c.businessPlans = "werwer";           // private data members cannot be accessed
        }

    }

    public class Company                            //PARENT CLASS
    {
        public string companyWebsite;               // Accessible to ALL the world

        protected string employeeLogin;             // Accessible ONLY to current Company class and employees of that company

        private string businessPlans;               // Only accessible to company owner

        public void someMethod()
        {
            companyWebsite = "12123123";            // Accessible to ALL the world

            employeeLogin = "21e12312";             // Accessible to Company class

            businessPlans = "efwef";                // private, so will be accessible ONLY to Company class
        }

        public void someothermethod()
        {
            businessPlans = "sdfsdfsdaf";
        }
    }

    class Employee2 : Company                       // CHILD CLASS
    {
        string employeeName;

        public Employee2()
        {
            companyWebsite = "3424324";             // Accessible because it was public

            employeeLogin = "432432";               // Accessible ONLY to child class as it was protected

            //businessPlans = "";                   // Not accessible as it was private
        }
    }
}
