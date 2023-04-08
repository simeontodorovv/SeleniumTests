
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class PracticePage 
{
    private readonly IWebDriver driver;
    public WebDriverWait wait;
    public PracticePage(IWebDriver driver) 
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
    public IWebElement RowOne => driver.FindElement(By.XPath("//input[@type='text']"));
    public IWebElement addBtn => driver.FindElement(By.Id("add_btn"));                    
    public IWebElement fieldOne => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"confirmation\"]")));
    public IWebElement RowTwo => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[contains(@type,'text')])[2]")));
    public IWebElement saveBtn => driver.FindElement(By.XPath("(//button[@id='save_btn'])[2]"));
    public IWebElement editBtn => wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("edit_btn")));
    public IWebElement fieldTwo => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='confirmation']")));

    public void TestCaseOne()
    {
        addBtn.Click();
    }
    public string fieldOneText()
    {
        return fieldOne.Text; 
    }
    public void TestCaseTwo()
    {
        addBtn.Click();
        RowTwo.SendKeys("Apple");
        saveBtn.Click();
    }
    public string fieldTwoText()
    {
        return fieldTwo.Text;
    }
    public void TestCaseThree()
    {
        editBtn.Click();
        Thread.Sleep(1000);
        RowOne.Clear();
        Thread.Sleep(1000);
        RowOne.SendKeys("Banana");
        Thread.Sleep(1000);
        addBtn.Click();
    }
    public string rowOneText()
    {
        return fieldOne.Text;
    }
}   
