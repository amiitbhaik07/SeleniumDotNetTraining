using System;
using System.Collections.Generic;

namespace SampleProject.learnCSharp
{
    class _10_Lists
    {
        static void Main10(string[] args)
        {
            List<string> myUSFriends = new List<string>();
            myUSFriends.Add("Amit");
            myUSFriends.Add("Greg");
            myUSFriends.Add("Don");
            myUSFriends.Add("Andrew");


            List<string> myIndianFriends = new List<string>();
            myIndianFriends.Add("Rahul");
            myIndianFriends.Add("Richa");
            myIndianFriends.Add("Ajay");


            //Clubbing two lists
            myIndianFriends.AddRange(myUSFriends);

            //Remove a particular element
            myIndianFriends.Remove("Don");

            //Remove a particular index
            myIndianFriends.RemoveAt(3);

            //Remove all elements
            myIndianFriends.Clear();







            Console.Read();


        }
    }
}
