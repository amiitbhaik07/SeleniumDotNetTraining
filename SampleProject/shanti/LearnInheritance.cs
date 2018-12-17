using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnInheritance
    {
        [Test]
        public void Inheritance()
        {
            // Is - A relationship

            //Every Dog is an Animal

            //Every Animal is NOT necessarily a Dog

            //Husky h = new Animal();               // Every Animal CANNOT be a Husky

            Animal a = new Husky();                 // Every Husky will be an Animal

            a.AnimalMethod();

            //a.DogMethod();

            //a.HuskyMethod();


            Dog d = new Husky();                    // Every Husky will obviously be a Dog

            d.AnimalMethod();

            d.DogMethod();

            //d.HuskyMethod();


            Husky h = new Husky();                  // Every Husky is obviously a Husky         // Most widely used

            h.AnimalMethod();

            h.DogMethod();

            h.HuskyMethod();



            Console.WriteLine();
        }
    }

    class Animal
    {
        public enum VOICE_TYPE { BARK , MEW }

        protected int noOfLegs = 4;

        protected VOICE_TYPE voice;

        protected string hairColour;

        public void AnimalMethod()
        {
            Console.WriteLine("I am in Animal");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            voice = VOICE_TYPE.BARK;
        }

        public void DogMethod()
        {
            Console.WriteLine("I am in Dog");
        }
    }

    class GermanS : Dog                         // Multi-level inheritance
    {
        public GermanS()
        {
            hairColour = "black";
        }

        public void GermanMethod()
        {
            Console.WriteLine("I am in GermanS");
        }
    }

    class Husky : Dog
    {
        public Husky()
        {
            hairColour = "golden";
        }

        public void HuskyMethod()
        {
            Console.WriteLine("I am in Husky");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            voice = VOICE_TYPE.MEW;
        }
    }
}
