using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnJS
    {
        [Test]
        public void abc()
        {
            // Java-script Execution in Selenium Webdriver

            // Two types : 1) Synchronous Java-script and 2) Asynchronous Java-script

            // 1) Synchronous java-script

            // 2) Asynchronous java-script


            IWebDriver driver = new ChromeDriver();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));








            // 1) Alert in java-script

            //js.ExecuteScript("alert('Hello Shanti!');");




            // 2) Click on any element

            IWebElement searchField = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("q")));

            searchField.SendKeys("selenium");

            IWebElement searchButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("btnK")));

            js.ExecuteScript("arguments[0].click();", searchButton);






            // 3) Scroll an element into view

            IWebElement nextLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@id='pnnext']/span[2]")));

            //js.ExecuteScript("arguments[0].scrollIntoView(true);", nextLink);





            // 4) Scrolling by Pixels

            js.ExecuteScript("window.scrollBy(0, 400);");



        }
    }
}
