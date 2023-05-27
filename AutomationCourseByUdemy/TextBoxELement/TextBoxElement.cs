
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V110.DOMSnapshot;

class TextBoxElement
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement Textbox;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/text-input-field/";

        driver.Navigate().GoToUrl(url);

        Textbox=driver.FindElement(By.Name("username"));

        Textbox.SendKeys("Nayab");
        Thread.Sleep(3000);
        Console.WriteLine(Textbox.GetAttribute("maxlength"));
        //Textbox.Clear();
        Thread.Sleep(3000);

        driver.Quit();
    }
}