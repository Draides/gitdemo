using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Edge;

namespace MSTestForJenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }
        
        private IWebDriver driver;
        private const string baseUrl = "https://www.onliner.by/";

        /*[TestInitialize]
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

        }*/

        [TestMethod]
        public void TestLogin()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(baseUrl);

            Console.WriteLine(driver.Title);
           // Assert.AreEqual(baseUrl, driver.Url);

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
