﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

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

       /* [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }*/
        
        private IWebDriver driver;
        private const string baseUrl = "https://www.onliner.by/";

        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Assert.AreEqual(baseUrl, driver.Url);
            Thread.Sleep(3000);
            driver.Quit();

        }

       /* [TestMethod]
        public void TestLogin()
        {
            Console.WriteLine(driver.Title);
           // Assert.AreEqual(baseUrl, driver.Url);

            Thread.Sleep(3000);
            driver.Quit();
        }*/
    }
}
