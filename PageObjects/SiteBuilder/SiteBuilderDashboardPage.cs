using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace mstest_sample.PageObjects.SiteBuilder
{
    public class SiteBuilderDashboardPage : PageObject, IIsCurrentPage
    {
        private readonly SiteBuilderDashboardPageSelectors _siteBuilderDashboardPageSelectors = new SiteBuilderDashboardPageSelectors();

        public SiteBuilderDashboardPage(IWebDriver driver)
            : base(driver)
        {
        }

        protected override string AbsolutePath
        {
            get
            {
                return "/Admin/";
            }
        }

        public bool IsCurrentPage()
        {
            IEnumerable<IWebElement> dashboardItems = Driver.FindElements(_siteBuilderDashboardPageSelectors.DashboardItems);
            return dashboardItems.Any() && dashboardItems.All(item => item.Displayed);
        }
    }
}