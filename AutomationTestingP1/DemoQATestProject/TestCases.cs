using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQATestProject
{
    public class TestCases :BaseTest
    {

        [Test]
        public void Email()
        {
           string Emailp="#philadelphia-field-email";

            driver.FindElement(By.CssSelector(Emailp)).SendKeys("nayab@gmail.com");
        }
    }
}
