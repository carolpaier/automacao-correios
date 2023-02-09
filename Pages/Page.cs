using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_b3.Pages
{
    public class Page
    {
        public static IWebDriver driver;
        
        public Page()
        {
            driver = new ChromeDriver();
        }

        public static void ClickElement(By by)
        {
            driver.FindElement(by).Click();
        }

        public void NavigateToUrl (string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void FillField(By by, string field)
        {
            driver.FindElement(by).SendKeys(field);
        }

        public string GetText (By by)
        {
            return driver.FindElement(by).Text;
        }

        public void EndTest()
        {
            driver.Quit();
        }

        public void Scroll()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 400);");
        }
        
    }
}
