using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace MSTestForJenkins.Webdriver.Test
{

    [TestClass]
    public class UnitTestOnliner
    {
        private IWebDriver driver;
        private const string baseUrl = "https://www.onliner.by/";

        [TestInitialize]
        public void Init()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Thread.Sleep(3000);
            driver.Quit();

        }

        [TestMethod]
        public void TestLogin()
        {

        }
    }
}
