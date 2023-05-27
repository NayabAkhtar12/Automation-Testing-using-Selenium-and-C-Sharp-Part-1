using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class DropDownMenu
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert AlertBox;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/alert-box/";

        string DropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(2)";

        driver.Navigate().GoToUrl(url);

        AlertBox = driver.SwitchTo().Alert();
        Console.WriteLine(AlertBox.Text);

        AlertBox.Accept();

        Thread.Sleep(3000); 

        driver.Quit();
    }

}