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
    public class LearnLocators2
    {

        //ID

        //XPath

        //CSS

        //LinkText

        //PartialLinkText

        //ClassName

        //TagName

        //Name

        IWebDriver driver;

        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in";
        }


        //XPATH ===> BY locator ===> WebElement ===> Perform action

        [Test]
        public void ChangeLanguages()
        {
            By settings = By.Id("fsettl");
            IWebElement settingsLink = driver.FindElement(settings);
            settingsLink.Click();


            //One single line:

            driver.FindElement(By.Id("fsettl")).Click();


            By searchSettings = By.XPath("//span[@id='fsett']/a");
            IWebElement searchSettingsLink = driver.FindElement(searchSettings);
            searchSettingsLink.Click();

            driver.FindElement(By.XPath("//span[@id='fsett']/a")).Click();


            By languages = By.XPath("//li[@id='langSecLink']/a");
            IWebElement languagesLink = driver.FindElement(languages);
            languagesLink.Click();


            By radioDeutch = By.XPath("//div[@id='langtde']/div/span");
            IWebElement deutchRadioButton = driver.FindElement(radioDeutch);
            deutchRadioButton.Click();



            By radioGroup = By.Id("langtop");
            IWebElement allLanguages = driver.FindElement(radioGroup);
            IReadOnlyCollection<IWebElement> allLang =  allLanguages.FindElements(By.TagName("div"));

            // FOR , WHILE , DO-WHILE

            //FOR-EACH LOOP

            foreach(IWebElement single in allLang)
            {
                single.Click();
            }




            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath));




        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Quit();
        }

    }
}
