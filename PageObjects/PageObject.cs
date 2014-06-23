using System;
using OpenQA.Selenium;

namespace mstest_sample.PageObjects
{
    public abstract class PageObject
    {
        protected abstract string AbsolutePath { get; }

        protected IWebDriver Driver
        {
            get; private set; }

        protected PageObject(IWebDriver driver)
        {
            Driver = driver;
        }

        protected void NavigateTo(string absolutePath)
        {
            var uriBuilder = new UriBuilder(Configuration.Current.Url);
            uriBuilder.Path = absolutePath;
            Driver.Navigate().GoToUrl(uriBuilder.ToString());
        }

        public bool IsCurrentPath()
        {
            var currentUri = new Uri(Driver.Url);
            return currentUri.AbsolutePath.ToLower() == AbsolutePath.ToLower();
        }
    }
}
