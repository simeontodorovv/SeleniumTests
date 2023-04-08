using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



public class LoginPageTests : Driver
{

    [Test]
    public void InvalidUserNameLoginTest()
    {
        var lp = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        lp.LogIn("username", "Password123");
        Assert.That(lp.GetErrorMessage(), Is.EqualTo("Your username is invalid!"));
    }
    [Test]
    public void InvalidPasswordLoginTest()
    {
        var lp = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        lp.LogIn("student", "password");
        Assert.That(lp.GetErrorMessage(), Is.EqualTo("Your password is invalid!"));
    }
    [Test]
    public void ValidLoginTest()
    {
        var lp = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        lp.LogIn("student", "Password123");
        Assert.That(lp.GetSuccessLoginMessage, Is.EqualTo("Logged In Successfully"));
    }
}