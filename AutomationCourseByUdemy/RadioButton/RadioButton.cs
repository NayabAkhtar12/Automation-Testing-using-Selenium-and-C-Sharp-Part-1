using OpenQA.Selenium;

class RadioButton
{
    static IWebDriver driver;
    static IWebElement Radiobutton;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/radio-button-test/";
        driver.Navigate().GoToUrl(url);
        string[] option = { "1", "2", "5" } ;
        for (int i = 0; i < option.Length; i++)
        {
            Radiobutton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option[i] + ")"));
            if (Radiobutton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("This Radion Button " + i + "is Checked");
            }
            else
            {
                Console.WriteLine("This Radion Button " + i + "is not  Checked");
            }
        }
       
    }
}