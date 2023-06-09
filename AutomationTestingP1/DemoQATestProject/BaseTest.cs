using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQATestProject
{
    [TestClass]
    public class BaseTest
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void login()
        {
            //https://demoqa.com/elements
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/guru99home/");
            driver.Manage().Window.Maximize();
            TestCases c1 = new TestCases(driver);
            c1.Email();
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}