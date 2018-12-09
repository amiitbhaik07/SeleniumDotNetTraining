using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SampleProject.selenium
{
    class _1_SampleScript
    {
        static IWebDriver driver;
        static IJavaScriptExecutor js;
        static WebDriverWait wait;

        [Test]
        public void Main1()
        {
            //A sample Selenium WebDriver script with EXTREMELY BASIC CODING concepts
            
            //Launch Chrome browser
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;

            //Maximize the window
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);         

            //Navigate to google website
            driver.Url = "https://www.google.co.in";

            //Click Settings link
            Click(By.Id("fsettl"));

            //Click Search Settings option
            Click(By.XPath("//span[@id='fsett']/a"));

            //Turn ON the Safe Search checkbox
            Click(By.XPath("//div[@id='ssc']/span"));

            //Slide the Results per page slider to 100 mark
            DragAndDrop(By.ClassName("goog-slider-thumb") , By.XPath("//div[@id='slruler']/following::ol/li[text()='100']"));

            //Check a checkbox
            Click(By.XPath("//div[@id='nwc']/span"));

            //Click on Show More link
            Click(By.Id("regionanchormore"));

            //Change the region to United States
            Click(By.XPath("//div[@data-value='US']/span"));

            //Navigate to Languages
            Click(By.Id("langSecLink"));

            //Change the language to Portugal
            Click(By.XPath("//div[@id='langtpt-PT']/div/span"));

            //Click Cancel button
            Click(By.XPath("//div[text()='Cancel']"));

            //Wait for the alert and accept it            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent()).Accept();
            Thread.Sleep(1000);

            //Type success in the search bar
            SendKeys(By.XPath("//input[@name='q']"), "Success");
        }

        public static void HighlightElement(IWebElement element)
        {
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 4px; border-style: solid; border-color: red"";";
            js.ExecuteScript(highlightJavascript, new object[] { element });
            Thread.Sleep(300);
            string unhighlightJavascript = @"arguments[0].style.cssText = ""border-width: 0px; border-style: solid; border-color: red"";";
            js.ExecuteScript(unhighlightJavascript, new object[] { element });
            Thread.Sleep(300);
            js.ExecuteScript(highlightJavascript, new object[] { element });
            Thread.Sleep(400);
            js.ExecuteScript(unhighlightJavascript, new object[] { element });
        }

        public static void ScrollIntoView(IWebElement element)
        {
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto',block: 'center',inline: 'center'});", element);
        }

        public static IWebElement WaitForElementVisible(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebElement WaitForElementClickable(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void Click(By locator)
        {
            IWebElement w = WaitForElementClickable(locator);
            ScrollIntoView(w);
            Thread.Sleep(500);
            HighlightElement(w);
            Thread.Sleep(1000);
            w.Click();
            Thread.Sleep(1000);
        }

        public static void SendKeys(By locator, string text)
        {
            IWebElement w = WaitForElementClickable(locator);
            ScrollIntoView(w);
            Thread.Sleep(500);
            HighlightElement(w);
            Thread.Sleep(1000);
            w.SendKeys(text);
            Thread.Sleep(1000);
        }

        public static void DragAndDrop(By start, By end)
        {
            IWebElement startW = WaitForElementVisible(start);
            IWebElement endW = WaitForElementVisible(end);
            Actions actions = new Actions(driver);
            HighlightElement(startW);
            actions.DragAndDrop(startW, endW).Build().Perform();
            Thread.Sleep(1000);
        }
    }
}