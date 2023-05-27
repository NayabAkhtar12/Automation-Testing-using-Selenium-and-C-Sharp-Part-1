using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTestingExecuteAutomation
{
    public class TestClass:BaseTest
    {
        [Test]
        public void Method1()
        {
            driver.Navigate().GoToUrl("https://localhost:44304/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        [Test]
        public void Login()
        {
            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("Nayab@gmail.com");
            Thread.Sleep(3000);
        }
    }
}