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
    class LearnSelectElement
    {
        [Test]
        public void abc()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "http://www.practiceselenium.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-title='Menu']"))).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Check Out']"))).Click();

            IWebElement cardType = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("card_type")));

            SelectElement select = new SelectElement(cardType);

             bool isM = select.IsMultiple;

            Console.WriteLine(isM); 

            IList<IWebElement> allOptions = select.Options;

            select.SelectByIndex(1);

            select.SelectByText("Diners Club");

            //select.SelectByValue("Visa");         //There is no attribute as 'value' and hence will fail at this step

            string selected = select.SelectedOption.Text;


            
        }
    }
}
