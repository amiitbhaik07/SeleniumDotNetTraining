using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SampleProject.learnSelenium
{
    class _3_LaunchBrowser
    {
        static void Main(string[] args)
        {
            //Launch different browsers

            IWebDriver chrome = new ChromeDriver();

            IWebDriver firefox = new FirefoxDriver();

            IWebDriver iexplore = new InternetExplorerDriver();




            //Maximize the window

            chrome.Manage().Window.Maximize();




            //Navigate to URL

            chrome.Url = "https://www.google.co.in";
        }
    }
}
