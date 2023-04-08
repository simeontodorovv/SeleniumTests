using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Driver
{
    public static IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        //options.AddArgument("--headless");
        //options.AddArgument("--disable-gpu");
        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}