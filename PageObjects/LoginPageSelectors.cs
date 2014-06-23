using OpenQA.Selenium;

namespace mstest_sample.PageObjects
{
    public class LoginPageSelectors
    {
        public readonly By Email = By.Id("Email");
        public readonly By Password = By.Id("Password");
        public readonly By SignIn = By.XPath("//input[@value='Sign In']");
        public readonly By Errors = By.XPath("//div[@class='validation-summary-errors']/ul/li");
    }
}