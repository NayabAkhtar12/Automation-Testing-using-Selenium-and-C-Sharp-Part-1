using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    public class TestClass
    {
        IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public  void Test()
        {
            driver.Navigate().GoToUrl("https://www.guru99.com/");
        }

        [TearDown] 
        public void TearDownBrowser() 
        {
            driver.Quit();
        }
    }
}
