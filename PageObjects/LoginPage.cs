using System.Linq;
using OpenQA.Selenium;

namespace mstest_sample.PageObjects
{
    public class LoginPage : PageObject, INavigateTo<LoginPage>
    {
        private readonly LoginPageSelectors _loginPageSelectors = new LoginPageSelectors();

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        public bool IsSignInEnabled()
        {
            return Driver.FindElement(_loginPageSelectors.SignIn).Enabled;
        }

        public void LogIn(string username, string password)
        {
            Driver.FindElement(_loginPageSelectors.Email).ClearAndSendKeys(username);
            Driver.FindElement(_loginPageSelectors.Password).ClearAndSendKeys(password);
            Driver.FindElement(_loginPageSelectors.SignIn).Click();
        }

        public string[] GetErrors()
        {
            return Driver.FindElements(_loginPageSelectors.Errors).Select(element => element.Text).ToArray();
        }

        protected override string AbsolutePath
        {
            get
            {
                return "/login/";
            }
        }

        public void NavigateTo()
        {
            NavigateTo(AbsolutePath);
        }
    }
}