using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

class CheckBoxElement
{
    static IWebElement checkboxelement;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/check-button-test-3/";
        string option = "1";
        IWebDriver driver = new EdgeDriver();
        driver.Navigate().GoToUrl(url);

        checkboxelement = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child("+ option+ ")"));
        
        if(checkboxelement.GetAttribute("Checked")=="true")
        {
            Console.WriteLine("Checkbox is checked");
        }
        else
        {
            Console.WriteLine("Checkbox is not checked");

        }

         option = "3";

        checkboxelement = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

        Console.WriteLine(checkboxelement.GetAttribute("Value"));
       //checkboxelement.Click(); 
       //Thread.Sleep(3000);
        driver.Quit();
    }
}