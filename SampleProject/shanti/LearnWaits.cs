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
    class LearnWaits
    {

        By settings = By.Id("fsettl");
        By searchSettings = By.XPath("//span[@id='fsett']/a");
        By languages = By.XPath("//li[@id='langSecLink']/a");
        By radioDeutch = By.XPath("//div[@id='langtde']/div/span");
        By cancelButton = By.XPath("//div[@id='form-buttons']/div[2]");

        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in";
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        [Test]
        public void WaitsSampleProgram()
        {
            //By settings = By.Id("fsettl");
            //IWebElement settingsLink = driver.FindElement(settings);
            //settingsLink.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(settings)).Click();



            //By searchSettings = By.XPath("//span[@id='fsett']/a");
            //IWebElement searchSettingsLink = driver.FindElement(searchSettings);
            //searchSettingsLink.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(searchSettings)).Click();



            //By languages = By.XPath("//li[@id='langSecLink']/a");
            //IWebElement languagesLink = driver.FindElement(languages);
            //languagesLink.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(languages)).Click();


            //By radioDeutch = By.XPath("//div[@id='langtde']/div/span");
            //IWebElement deutchRadioButton = driver.FindElement(radioDeutch);
            //deutchRadioButton.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(radioDeutch)).Click();


            wait.Until(ExpectedConditions.ElementToBeClickable(cancelButton)).Click();


            wait.Until(ExpectedConditions.AlertIsPresent()).Accept();
        }


















        public void abc()
        {
            //1) Implicit Wait

            //Browser implicit wait = 30 seconds

            //Launch browser, open Google website

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);

            driver.FindElement(By.Id("abc")).Click();           //Appears after 3 seconds of pageload

            driver.FindElement(By.Id("def")).Click();           //Appears Immediately

            driver.FindElement(By.Id("ghi")).Click();           //Appears after 10 seconds

            // 1 | 2 | 3 | 4 | 5 | 6 === Exception


            //300 seconds to load
















            //2) Explicit Wait

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.AlertIsPresent());

            wait.Until(ExpectedConditions.ElementExists(By.Id("")));

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("")));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("")));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("")));































        }
    }
}
