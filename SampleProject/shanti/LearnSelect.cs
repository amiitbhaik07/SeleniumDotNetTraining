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
    class LearnSelect
    {
        [Test]
        public void abc()
        {

            //SelectElement ==> Dropdown ==> Tagname = 'select'

            //We can use SelectElement ONLY and ONLY when the Tag of that dropdown is 'select'



            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "http://www.practiceselenium.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-title='Menu']"))).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Check Out']"))).Click();

            IWebElement cardTypeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("card_type")));



            SelectElement select = new SelectElement(cardTypeDropdown);


            bool isMultiSelect = select.IsMultiple;

            IList<IWebElement> allOptions = select.Options;

            select.SelectByIndex(1);

            select.SelectByText("Mastercard");

            string selectedOption = select.SelectedOption.Text;







        }


    }
}
