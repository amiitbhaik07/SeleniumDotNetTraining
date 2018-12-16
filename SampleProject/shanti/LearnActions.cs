using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnActions
    {
        [Test]
        public void learnActions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://www.amazon.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            IWebElement departments = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@id='nav-link-shopall']/span[2]")));

            Actions actions = new Actions(driver);

            //Mouse Hover
            //actions.MoveToElement(departments).Perform();


            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));

            //Send keys and hit Enter
            //actions.SendKeys(searchBox, "echo");
            //actions.SendKeys(searchBox, Keys.Enter);
            //actions.Build().Perform();


            //Right Click
            //actions = new Actions(driver);
            //actions.ContextClick(searchBox).Build().Perform();



            //
            actions = new Actions(driver);
            actions.Build().Perform();

        }
    }
}
