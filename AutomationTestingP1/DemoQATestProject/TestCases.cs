using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQATestProject
{
    public class TestCases 
    {
        IWebDriver driver;
        public TestCases(IWebDriver driver)
        {
            this.driver = driver;
        }

        By EmailP = By.CssSelector("#philadelphia-field-email");

        public void Email()
        {
            driver.FindElement(EmailP).SendKeys("nayab@gmail.com");
        }
    }
}
