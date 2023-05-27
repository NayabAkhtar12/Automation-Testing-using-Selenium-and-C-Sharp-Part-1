using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class DropDownMenu
{
    static IWebDriver driver;
    static IWebElement DropDown;
    static IWebElement ElementFromDropDown;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/drop-down-menu-test/";
        string DropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(2)";
      driver=new ChromeDriver(url); 
        driver.Navigate().GoToUrl(url);
        // string[] option = { "1", "2", "5" };'
        DropDown = driver.FindElement(By.Name("DropDownTest"));
            Console.WriteLine(DropDown.GetAttribute("value"));
            ElementFromDropDown = driver.FindElement(By.CssSelector(DropDownMenuElements));
        Console.WriteLine(ElementFromDropDown);
        ElementFromDropDown.Click();    

        driver.Quit();  
    }

}