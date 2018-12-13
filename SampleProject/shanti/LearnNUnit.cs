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
    class LearnNUnit
    {

        [Test]
        public void VerifySearch()
        {
            Console.WriteLine("VerifySearch");

            //Launch a browser
            IWebDriver driver = new ChromeDriver();

            //Maximize the browser window
            driver.Manage().Window.Maximize();

            //Navigating to https://www.google.com
            driver.Url = "https://www.google.com";

            //Enter text in search box
            //Search for 'CNN News'
            IWebElement searchBox = driver.FindElement(By.XPath("//input[@name='q']"));
            searchBox.SendKeys("India");


            //Locator mechanisms total 8 :

            By by = By.Name("abc");


            by = By.Id("schedule-later");      


            by = By.ClassName("btn btn-primary step-indicator-target");


            by = By.LinkText("csharp's Meeting");


            by = By.PartialLinkText("Meeting");


            by = By.TagName("span");


            by = By.CssSelector("");

            //CSSSELECTOR by - ID , CLASS , VALUE

            //ID with CSS , we have to use hash sign : tag#id

            by = By.CssSelector("button#schedule-later");

            //CLASS with CSS , we have to use dot sign : tag.class

            by = By.CssSelector("button.employee");

            //ATTRIBUTE with TAG , we have to use [] : tag[attribute=value]

            by = By.CssSelector("button[data-container=body]");







            //We just learnt... ITS THE MOST EFFECTIVE way lof locating


            //80% of cases
            by = By.XPath("");










            by = By.Id("schedule-later");

            by = By.XPath("//button[@id='schedule-later']");

            driver = new ChromeDriver();

            IWebElement scheduleLaterButton = driver.FindElement(by);

            scheduleLaterButton.Click();


            by = By.XPath("//input[@name='q']");

            IWebElement searchTextBox = driver.FindElement(by);

            searchTextBox.SendKeys("text");


            searchTextBox.Clear();

            searchTextBox.SendKeys("Write in textbox");

            string textInWebElement = searchTextBox.Text;




            // XPATH ===> BY locator ===> WEB ELEMENT ===> perform actions like CLICK, SENDKEYS etc.

        }
        

    }
}
