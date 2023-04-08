using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;

public class LoginPage 
{
    private readonly IWebDriver _driver;
    public WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this._driver = driver;
        wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
    }

    public IWebElement Username => _driver.FindElement(By.Id("username"));
    public IWebElement Password => _driver.FindElement(By.Id("password"));
    public IWebElement Submit => _driver.FindElement(By.Id("submit"));
    public IWebElement Error => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='error']")));
    public IWebElement LogInSuccess => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[@class='post-title']")));


    public void LogIn(string userName, string passWord)
    {
        Username.Clear();
        Username.SendKeys(userName);
        Password.Clear();
        Password.SendKeys(passWord);
        Submit.Click();
    }

    public string GetErrorMessage()
    {
        return Error.Text;
    }
    public string GetSuccessLoginMessage()
    {
        return LogInSuccess.Text;
    }
}