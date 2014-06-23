using OpenQA.Selenium;

namespace mstest_sample.PageObjects.DevCenter
{
    public class DevCenterDashboardPage : PageObject, IIsCurrentPage
    {
        public DevCenterDashboardPage(IWebDriver driver)
            : base(driver)
        {
        }

        protected override string AbsolutePath
        {
            get
            {
                return "/Console/";
            }
        }

        public bool IsCurrentPage()
        {
            return IsCurrentPath() && Driver.Title.Contains("Dev Center");
        }
    }
}