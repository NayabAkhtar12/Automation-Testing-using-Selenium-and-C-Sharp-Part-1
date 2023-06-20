﻿using NUnit.Framework;
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
            By EmailP = By.CssSelector("#philadelphia-field-email");

            driver.FindElement(EmailP).SendKeys("nayab@gmail.com");
        }
    }
}
