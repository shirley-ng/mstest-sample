using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace mstest_sample.PageObjects
{
    public class LaunchpadPage : PageObject
    {
        private readonly LaunchpadPageSelectors _launchpadPageSelectors = new LaunchpadPageSelectors();

        public LaunchpadPage(IWebDriver driver)
            : base(driver)
        {
        }

        public string GetUsername()
        {
            var waitForLogin = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            waitForLogin.Until(d => d.FindElements(_launchpadPageSelectors.UserMenuTrigger).Any());
            return Driver.FindElement(_launchpadPageSelectors.UserMenuTrigger).Text;
        }

        public void ChooseDeveloperAccount(string accountName)
        {
            var developerAccounts = Driver.FindElements(_launchpadPageSelectors.DeveloperAccounts);
            var matchingAccount = developerAccounts.FirstOrDefault(d => d.Text == accountName);
            if (matchingAccount == null)
            {
                throw new InvalidOperationException(String.Format("Unable to locate developer account matching {0}", accountName));
            }
            matchingAccount.Click();

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.Title != "Choose a destination");
        }

        public void ChooseAccount(string accountName)
        {
            var siteBuilderAccounts = Driver.FindElements(_launchpadPageSelectors.SiteBuilderAccounts);
            var matchingAccount = siteBuilderAccounts.FirstOrDefault(d => d.Text == accountName);
            if (matchingAccount == null)
            {
                throw new InvalidOperationException(String.Format("Unable to locate account matching {0}", accountName));
            }
            matchingAccount.Click();

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.Title != "Choose a destination");
        }

        protected override string AbsolutePath
        {
            get
            {
                return "/login/";
            }
        }
    }
}