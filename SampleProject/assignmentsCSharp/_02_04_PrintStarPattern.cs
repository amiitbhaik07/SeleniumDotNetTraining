using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _02_04_PrintStarPattern
    {
        static void Main_2_4(string[] args)
        {
            //Print this pattern
            //*
            //**
            //***
            //****
            //*****

            for(int i=1; i<=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
