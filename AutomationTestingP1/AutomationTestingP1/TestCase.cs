using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestingP1
{
    public class TestCase : BaseTest
    {
        


        [Test]
        public void Method1()
        {
            string CssPath = "#philadelphia-field-email";

            IWebElement Email = driver.FindElement(By.CssSelector(CssPath));
            Email.SendKeys("nayab@gmail.com");
            string Csspath1 = "#philadelphia-field-submit";
            IWebElement Submit = driver.FindElement(By.CssSelector(Csspath1));
            Submit.Click();
            Thread.Sleep(3000);
        }
       
      
        //Xpath Selector
        [Test]
        public void Method2()
        {
            string Xpath = "//*[@id=\"philadelphia-field-email\"]";
            IWebElement Email = driver.FindElement(By.XPath(Xpath));
            Email.SendKeys("nayab@gmail.com");
            string Xpath1 = "/html/body/div[4]/section/div[2]/div/div[3]/div/div/div[1]/div/div/div/article/form/button";
            IWebElement Submit = driver.FindElement(By.XPath(Xpath1));
            Submit.Click();
            Thread.Sleep(3000);
        }

        //Dropdown
        [Test]
        public void Method3()
        {
            string css = "#awf_field-91977689";
            IWebElement DropDown = driver.FindElement(By.CssSelector(css));

            var Option = new SelectElement(DropDown);

            Option.SelectByValue("sapfico99");
            Thread.Sleep(3000);
        }

        [Test]
        public void Method4()
        {
            // IWebElement Title = driver.FindElement(By.TagName("title"));
            Assert.AreEqual("Google", driver.Title);
            // Thread.Sleep(3000);
        }


    }
}