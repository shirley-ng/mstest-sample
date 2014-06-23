using Microsoft.VisualStudio.TestTools.UnitTesting;
using mstest_sample.PageObjects;
using mstest_sample.PageObjects.DevCenter;
using mstest_sample.PageObjects.SiteBuilder;

namespace mstest_sample.Tests
{
    [TestClass]
    public class LaunchpadTests : UITestClass
    {
        [TestMethod]
        public void Launchpad_Choose_Account()
        {
            var loginPage = new LoginPage(Driver);
            var launchpadPage = new LaunchpadPage(Driver);
            var siteBuilderDashboardPage = new SiteBuilderDashboardPage(Driver);
            loginPage.NavigateTo();
            loginPage.LogIn(Configuration.Current.Username, Configuration.Current.Password);

            launchpadPage.ChooseAccount("mztest10");

            Assert.IsTrue(siteBuilderDashboardPage.IsCurrentPage());
        }

        [TestMethod]
        public void Launchpad_Choose_Developer_Account()
        {
            var loginPage = new LoginPage(Driver);
            var launchpadPage = new LaunchpadPage(Driver);
            var devCenterDashboardPage = new DevCenterDashboardPage(Driver);
            loginPage.NavigateTo();
            loginPage.LogIn(Configuration.Current.Username, Configuration.Current.Password);

            launchpadPage.ChooseDeveloperAccount("Mozu QA");

            Assert.IsTrue(devCenterDashboardPage.IsCurrentPage());
        }
    }
}