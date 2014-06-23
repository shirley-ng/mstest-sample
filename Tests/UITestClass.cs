using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace mstest_sample.Tests
{
    public class UITestClass
    {
        protected IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                Driver = DriverFactory.Current.Create(Configuration.Current.Browser);
            }
            catch (Exception)
            {
                TestCleanup();
                throw;
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}