using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnExceptions
    {
        [Test]
        public void abc()
        {
            int a = 10;

            int b = 2;

            try
            {
                Console.WriteLine(a / b);
            }
            catch (NullReferenceException e1)
            {
                Console.WriteLine("Any other exception");
            }
            catch (DivideByZeroException e2)
            {
                Console.WriteLine("Division by zero not possible");
            }
            catch (Exception e)
            {
                Console.WriteLine("Not possible");
            }
            finally
            {
                Console.WriteLine("Will be executed inspite an exception occurs or not!");
            }


            //throw new Exception("My customized Exception");


            try
            {
                throw new Exception("My customized Exception");
            }
            catch(Exception e)
            {
                Console.WriteLine("Wow, I've caught the exception here!");
            }

        }
    }
}
