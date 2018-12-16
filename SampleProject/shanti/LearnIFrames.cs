using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnIFrames
    {
        [Test]
        public void learnIFrames()
        {
            IWebDriver driver = new ChromeDriver();

            IWebElement innerDocument = driver.FindElement(By.Id("abc"));

            driver.SwitchTo().Frame(innerDocument);

            //Perform some operations

            //Now we can enter text inside any textfields present inside the inner Document
            
            //Switch the focus back to the ORIGINAL parent document

            driver.SwitchTo().DefaultContent();

            //Continue to interact with the elements present inside the original parent document.

        }
    }
}
