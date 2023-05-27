using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

class BaseClass
{
    static void Main()
    {

        IWebDriver driver = new ChromeDriver();
        //  IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
        driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/");
        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
           Green("I can  see the element");
        }
        else
        {
            Red("Well ,I can't see the Element");
        }
        //  Thread.Sleep(3000);
        driver.Quit();
    }

    private static void Red(string v)
    {
        Console.ForegroundColor=ConsoleColor.Red;
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