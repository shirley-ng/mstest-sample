using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace mstest_sample
{
    public class DriverFactory
    {
        private static DriverFactory _current;

        public static DriverFactory Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new DriverFactory();
                }
                return _current;
            }
        }

        private DriverFactory()
        {
        }

        public IWebDriver Create(string browser)
        {
            switch (browser)
            {
                case "firefox":
                    return new FirefoxDriver();
                case "chrome":
                    return new ChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("browser");
            }
        }
    }
}