using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.shanti
{
    class LearnActions1
    {
        [Test]
        public void abc()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            Actions actions = new Actions(driver);



            // 1) Mouse-hover using Actions

            //IWebElement departments = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@id='nav-link-shopall']/span[2]")));

            //actions.MoveToElement(departments).Build().Perform();




            // 2) Enter text in a textfield

            //IWebElement searchTextfield = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("twotabsearchtextbox")));

            //actions.MoveToElement(searchTextfield).Click(searchTextfield).SendKeys(searchTextfield, "echo").Build().Perform();

            //actions.MoveToElement(searchTextfield);
            //actions.Click(searchTextfield);
            //actions.SendKeys(searchTextfield, "echo");
            //actions.SendKeys(Keys.Enter);
            //actions.Build().Perform();




            // 3) Hit specific KEYBOARD keys using Actions

            //actions.SendKeys(Keys.Enter);

            //actions.KeyDown(Keys.ArrowDown);

            //actions.KeyUp(Keys.ArrowDown);




            // 4) Drag and Drop using Actions

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("fsettl"))).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@id='fsett']/a"))).Click();

            //IWebElement elementToBeDragged = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='goog-slider-thumb']")));

            //IWebElement destination = driver.FindElement(By.XPath("//div[@class='sllabel slslow']"));

            //actions.DragAndDrop(elementToBeDragged, destination);

            //actions.Build().Perform();




            // 5) We can perform MOUSE operations - Double click and Right click

            IWebElement elementToDoubleClick = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[text()='SafeSearch Filters']")));

            //actions.DoubleClick(elementToDoubleClick);

            //actions.ContextClick(elementToDoubleClick);

            //actions.Build().Perform();




            // 6) Click and Hold / Release

            //actions.ClickAndHold();

            //delay

            //actions.Release();






        }
    }
}
