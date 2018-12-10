using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.assignmentsCSharp
{
    class _02_05_VovelOrConsonent
    {
        static void Main_2_5(string[] args)
        {
            //Accept an alphabet from console and print whether it is a Vowel or Consonent

            Console.WriteLine("Please enter any alphabet");

            char ch = Char.Parse(Console.ReadLine());

            bool isVowel = false;

            switch(ch)
            {
                case 'a':
                    isVowel = true;
                    break;

                case 'e':
                    isVowel = true;
                    break;

                case 'i':
                    isVowel = true;
                    break;

                case 'o':
                    isVowel = true;
                    break;

                case 'u':
                    isVowel = true;
                    break;

                default:
                    isVowel = false;
                    break;
            }

            

            if(isVowel)
                Console.WriteLine("Alphabet '" + ch + "' is a Vowel");
            else
                Console.WriteLine("Alphabet '" + ch + "' is a Consonent");


            Console.Read();
        }
    }
}
