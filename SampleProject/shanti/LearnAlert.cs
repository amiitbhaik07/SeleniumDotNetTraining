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
    class LearnAlert
    {
        [Test]
        public void DoNotHandleAlert()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            //Settings
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("fsettl"))).Click();

            //Search Settings
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@id='fsett']/a"))).Click();

            //Languages
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[@id='langSecLink']/a"))).Click();
            
            //Cancel Button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='form-buttons']/div[2]"))).Click();

            //Script will fail here if we do not handle alert!

            //Search for 'Selenium'
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("q"))).SendKeys("selenium");
        }

        [Test]
        public void HandleAlert()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.google.co.in";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            //Settings
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("fsettl"))).Click();

            //Search Settings
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@id='fsett']/a"))).Click();

            //Languages
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[@id='langSecLink']/a"))).Click();

            //Cancel Button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='form-buttons']/div[2]"))).Click();

            //Script will fail here if we do not handle alert!
            //Handle Alert here!

            wait.Until(ExpectedConditions.AlertIsPresent());

            IAlert alert = driver.SwitchTo().Alert();

            //Dismiss the alert (click on CANCEL button)
            //alert.Dismiss();

            //Fetch the text from Alert and save it in this variable
            //string textOnAlertPopup = alert.Text;
            //Console.WriteLine(textOnAlertPopup);

            //Set authentication using Alert
            //alert.SetAuthenticationCredentials("username", "password");
            
            //Accept the alert (click on OK button)
            //alert.Accept();

            //Search for 'Selenium'
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("q"))).SendKeys("selenium");
        }
    }
}
