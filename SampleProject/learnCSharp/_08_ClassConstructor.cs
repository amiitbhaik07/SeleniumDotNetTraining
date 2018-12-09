using static SampleProject.learnCSharp._08_ClassConstructor;

namespace SampleProject.learnCSharp
{
    class _08_ClassConstructor
    {
        public enum MAKE { SUZUKI, HYUNDAI, SKODA }
        public enum TYPE { PETROL, DIESEL }

        static void Main8(string[] args)
        {

            Cars myCar = new Cars();
            myCar.cc = 1600;
            myCar.maxSpeed = 300;
            myCar.make = MAKE.SKODA;
            myCar.type = TYPE.DIESEL;
            myCar.name = "Laura";



            AdvancedCars myNewCar = new AdvancedCars(1600, 300, MAKE.SKODA, TYPE.DIESEL, "Laura");

        }
    }

    class Cars
    {
        public int cc;
        public int maxSpeed;
        public MAKE make;
        public TYPE type;
        public string name;
    }

    class AdvancedCars
    {
        public int cc;
        public int maxSpeed;
        public MAKE make;
        public TYPE type;
        public string name;

        public AdvancedCars(int cc, int maxSpeed, MAKE make, TYPE type, string name)
        {
            this.cc = cc;
            this.maxSpeed = maxSpeed;
            this.type = type;
            this.name = name;
        }
    }
}
