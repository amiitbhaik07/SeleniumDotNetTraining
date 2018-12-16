using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnJSExecution
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        IWebElement searchTextfield, searchButton;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.google.co.in";
            searchTextfield = driver.FindElement(By.Name("q"));
            searchTextfield.SendKeys("selenium");
            searchButton = driver.FindElement(By.Name("btnK"));
        }


        [Test]
        public void lSleep()
        {
            //Thread.Sleep in Javascript
            js.ExecuteAsyncScript("window.setTimeout(arguments[arguments.length - 1], 5000);");

            //This will get clicked after 5 seconds
            searchButton.Click();
        }

        [Test]
        public void lAlert()
        {
            //Generate Alert
            js.ExecuteScript("alert('Hello alert!');");
        }

        [Test]
        public void lClick()
        {
            //Click on any element
            js.ExecuteScript("arguments[0].click();", searchButton);
        }

        [Test]
        public void lScroll1()
        {
            //Click on any element
            js.ExecuteScript("arguments[0].click();", searchButton);

            IWebElement nextPageLink = driver.FindElement(By.LinkText("Next"));

            //Scroll element into view
            js.ExecuteScript("arguments[0].scrollIntoView(true);", nextPageLink);
        }

        [Test]
        public void lScroll2()
        {
            //Click on any element
            js.ExecuteScript("arguments[0].click();", searchButton);

            IWebElement nextPageLink = driver.FindElement(By.LinkText("Next"));

            Thread.Sleep(2000);

            //Scroll Page
            js.ExecuteScript("window.scrollBy(0,400);");
        }


        public void lGettext()
        {
            //Click on any element
            js.ExecuteScript("arguments[0].click();", searchButton);

            IWebElement nextPageLink = driver.FindElement(By.LinkText("Next"));

            Thread.Sleep(2000);

            //Get inner text of any field
            js.ExecuteScript("arguments[0].innerText", searchTextfield);
        }
    }
}
