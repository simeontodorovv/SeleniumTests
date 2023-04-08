using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class PracticePageTests : Driver
{
    [Test]
    public void FirstTest()
    {
        var pp = new PracticePage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-exceptions/");
        pp.TestCaseOne();
        Assert.That(pp.fieldOneText, Is.EqualTo("Row 2 was added"));
    }
    [Test]
    public void SecondTest()
    {
        var pp = new PracticePage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-exceptions/");
        pp.TestCaseTwo();
        Assert.That(pp.fieldTwoText, Is.EqualTo("Row 2 was saved"));
    }
    [Test]
    public void ThirdTest()
    {
        var pp = new PracticePage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-exceptions/");
        pp.TestCaseThree();
        Assert.That(pp.rowOneText, Is.EqualTo("Row 2 was added"));
    }
}