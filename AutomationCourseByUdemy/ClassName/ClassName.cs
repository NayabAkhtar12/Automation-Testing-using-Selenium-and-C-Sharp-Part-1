
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

class ClassName
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/class-name/";
        IWebDriver driver = new ChromeDriver();
        string ID = "testClass";
        //  IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.ClassName(ID));
        Console.WriteLine(element.Text);
        //if (element.Displayed)
        //{
        //    Green("I can  see the element");
        //}
        //else
        //{
        //    Red("Well ,I can't see the Element");
        //}
        //  Thread.Sleep(3000);
        driver.Quit();
    }

    private static void Red(string v)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(v);
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;

    }

    private static void Green(string v)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;

        Console.ReadLine();
    }
}