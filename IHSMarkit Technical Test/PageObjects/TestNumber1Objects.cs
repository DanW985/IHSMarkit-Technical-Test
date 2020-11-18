using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using NUnit;
using NUnit.Framework;

namespace IHSMarkit_Technical_Test.PageObjects
{
    public class TestNumber1Objects
    {
        private IWebDriver driver;

        public TestNumber1Objects(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement runButton => driver.FindElement(By.Id("run-button"));

        public void clickTheRunButtonAndCheckOutput()
        {
            runButton.Click();
            Thread.Sleep(1000);
            string outputMessage = driver.FindElement(By.Id("output")).Text;
            string expectedText = "Hello World";
            Assert.AreEqual(outputMessage, expectedText);
        }
        
    }
}
