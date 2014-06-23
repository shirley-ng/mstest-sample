using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mstest_sample.PageObjects;

namespace mstest_sample.Tests
{
    [TestClass]
    public class LoginTests : UITestClass
    {
        [TestMethod]
        public void Login_Invalid_Password_Display_Error()
        {
            string expectedError = String.Format("Invalid Credentials: {0}.", Configuration.Current.Username);

            var loginPage = new LoginPage(Driver);
            loginPage.NavigateTo();
            loginPage.LogIn(Configuration.Current.Username, "esrwerew");
            string[] resultErrors = loginPage.GetErrors();

            Assert.IsTrue(resultErrors.Count(error => error == expectedError) == 1);
        }

        [TestMethod]
        public void Login_No_Credentials_Disable_Sign_In()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.NavigateTo();
            loginPage.LogIn(" ", "");

            bool resultIsSignInEnabled = loginPage.IsSignInEnabled();

            Assert.IsFalse(resultIsSignInEnabled);
        }

        [TestMethod]
        public void Login_Valid_Credentials_Sign_In()
        {
            string expectedUsername = Configuration.Current.Username;
            var loginPage = new LoginPage(Driver);
            var launchpadPage = new LaunchpadPage(Driver);
            loginPage.NavigateTo();

            loginPage.LogIn(expectedUsername, Configuration.Current.Password);
            string resultUsername = launchpadPage.GetUsername();

            Assert.AreEqual(expectedUsername, resultUsername);
        }
    }
}