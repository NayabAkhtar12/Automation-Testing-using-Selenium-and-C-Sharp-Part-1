using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingExecuteAutomation
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44304/");
            driver.Manage().Window.Maximize();
        }



        [TearDown]
        public void TearDownBrowser()
        {
            driver.Quit();
        }
    }
}
