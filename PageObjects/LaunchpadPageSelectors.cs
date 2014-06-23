using OpenQA.Selenium;

namespace mstest_sample.PageObjects
{
    public class LaunchpadPageSelectors
    {
        public readonly By UserMenuTrigger = By.ClassName("user-menu-trigger");
        public readonly By DeveloperAccounts = By.XPath("//*[contains(@class, 'scopes-container-devcenter')]/p/a");
        public readonly By SiteBuilderAccounts = By.XPath("//*[contains(@class, 'scopes-container-sitebuilder')]/p/a");
    }
}