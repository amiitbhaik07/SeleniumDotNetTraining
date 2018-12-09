namespace SampleProject.learnCSharp
{
    class _09_DifferentVariableStates
    {

        static Students s1 = new Students();            //Class variable - will always be static

        Students s2 = new Students();                   //Instance variable - outside any method but inside the class

        static void Main9(string[] args)
        {
            Students s3 = new Students();                //Local variable - inside the method
        }

        void method()
        {
            s1 = null;

            s2 = null;

            //s3 = null;            //Not possible
        }
    }

    class Students
    {
        public static string collegeName = "MIT";
        public string name;
        public int standard;
    }
}
