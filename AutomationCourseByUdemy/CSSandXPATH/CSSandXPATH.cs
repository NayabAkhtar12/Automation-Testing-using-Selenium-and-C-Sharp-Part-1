
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

class CSSandXPATH
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/css-path/";
        string url2 = "https://testing.todorvachev.com/text-input-field/";
        string Csspath = "#post-108 > div > figu> img";
        string Xpath = "//*[@id=\"post-108\"]/div/figure/img";
        IWebDriver driver = new ChromeDriver();
        string ID = "testClass";
        //  IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
        driver.Navigate().GoToUrl(url);
        IWebElement Csselement  ;
        IWebElement Xpathelement = driver.FindElement(By.XPath(Xpath));
        try
        {
            Csselement= driver.FindElement(By.CssSelector(Csspath));
            if (Csselement.Displayed)
            {
                Green("I can  see the Css element");
            }
        }
        catch (NoSuchElementException)
        {

            Red("Well ,I can't see the Element");
        }


        //  Thread.Sleep(3000);
        if (Xpathelement.Displayed)
        {
            Green("I can  see the Xpath element");
        }
        else
        {
            Red("Well ,I can't see the Element");
        }
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
