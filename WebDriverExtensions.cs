using OpenQA.Selenium;

namespace mstest_sample
{
    public static class WebElementExtensions
    {
        public static void ClearAndSendKeys(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}