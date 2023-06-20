using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQATestProject
{
    public class BaseTest
    {
       public IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void login()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

        }

        [OneTimeTearDown]
        public void exit()
        {
            driver.Quit();

        }
    }
}