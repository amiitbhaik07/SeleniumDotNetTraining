namespace SampleProject.learnCSharp
{
    class _11_AccessModifiersInheritance
    {
        static void Main11(string[] args)
        {
            Company c = new Company();

            c.companyWebsite = "website";

            //c.employeeLogin = "";                 //Not allowed

            //c.businessPlan = "";                  //Not allowed
        }
    }

    class Company
    {

        public string companyWebsite;               //This should be publicly available

        protected string employeeLogin;             //This should be available only to Employees of that company

        private string businessPlan;                //This is confidential, and should be available only to company owner

    }

    class Employee : Company
    {
        public Employee()
        {
            companyWebsite = "";

            employeeLogin = "";

            //businessPlan = "";                    //Not accessible even to the Child class
        }
    }
}
